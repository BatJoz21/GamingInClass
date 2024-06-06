using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quiz : MonoBehaviour
{
    [Header("Questions")]
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private Image questionImage;
    [SerializeField] private List<QuestionSO> questions = new List<QuestionSO>();
    [SerializeField] private List<QuestionSO> questionsA = new List<QuestionSO>();
    [SerializeField] private List<QuestionSO> questionsB = new List<QuestionSO>();
    private QuestionSO currentQuestion;
    
    [Header("Answer")]
    [SerializeField] private GameObject[] answerButtons;
    int correctAnswerIndex;
    bool hasAnsweredEarly = true;

    [Header("Buttons")]
    [SerializeField] private Sprite defaultAnswerSprite;
    [SerializeField] private Sprite correctAnswerSprite;

    [Header("Timer")]
    [SerializeField] private Image timerImage;
    Timer timer;

    [Header("Scoring")]
    [SerializeField] TextMeshProUGUI scoreText;
    Scorekeeper scoreKeeper;

    [Header("Progress Bar")]
    [SerializeField] private Slider progressBar;

    public bool isComplete;
    private GameManager gameManager;
    private AudioManager audioManager;

    void Awake()
    {
        timer = FindObjectOfType<Timer>();
        scoreKeeper = FindObjectOfType<Scorekeeper>();
        gameManager = FindObjectOfType<GameManager>();
        audioManager = FindObjectOfType<AudioManager>();
        progressBar.maxValue = questions.Count;
        progressBar.value = 0;
    }

    void Start()
    {
        /*
        if (gameManager.QuestionType == 0)
        {
            for (int i = 0; i <= 8; i++)
            {
                questions[i] = questionsA[i];
            }
        }
        else if (gameManager.QuestionType == 1)
        {
            for (int i = 0; i <= 8; i++)
            {
                questions[i] = questionsB[i];
            }
        }
        else
        {
            for (int i = 0; i <= 8; i++)
            {
                questions[i] = questionsA[i];
            }
        }
        */
    }

    void Update()
    {
        timerImage.fillAmount = timer.fillFraction;
        if (timer.loadNextQuestion)
        {
            if (progressBar.value == progressBar.maxValue)
            {
                isComplete = true;
                return;
            }
            hasAnsweredEarly = false;
            GetNextquestion();
            timer.loadNextQuestion = false;
        }
        else if (!hasAnsweredEarly && !timer.GetIsAnsweringQuestion())
        {
            hasAnsweredEarly= true;
            DisplayAnswer(-1);
            SetButtonState(false);
        }
    }

    private void DisplayQuestion()
    {
        questionText.text = currentQuestion.GetQuestion();
        questionImage.sprite = currentQuestion.GetQuestionImage();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = currentQuestion.GetAnswer(i);
        }
    }

    private void GetNextquestion()
    {
        if (questions.Count > 0)
        {
            SetButtonState(true);
            SetDefaultButtonSprite();
            GetRandomQuestion();
            DisplayQuestion();
            progressBar.value++;
            scoreKeeper.IncrementQuestionSeen();
        }
        else
        {
            //???
        }
    }

    private void GetRandomQuestion()
    {
        int index = Random.Range(0, questions.Count);
        currentQuestion = questions[index];
        if (questions.Contains(currentQuestion))
        {
            questions.Remove(currentQuestion);
        }
    }

    public void OnAnswerSelected(int index)
    {
        hasAnsweredEarly = true;
        DisplayAnswer(index);
        SetButtonState(false);
        timer.CancelTimer();
        scoreText.text = "Score: " + scoreKeeper.CalculateScore() + "%";
    }

    private void DisplayAnswer(int index)
    {
        Image buttonImage;
        if (index == currentQuestion.GetCorrectAnswerIndex())
        {
            questionText.text += "\n Jawaban anda benar!";
            buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
            audioManager.PlaySFX("Correct");
            scoreKeeper.IncrementCorrectAnswer();
        }
        else
        {
            correctAnswerIndex = currentQuestion.GetCorrectAnswerIndex();
            string correctAnswer = currentQuestion.GetAnswer(correctAnswerIndex);
            questionText.text += "\n Jawaban anda salah! Jawaban yang benar adalah " + correctAnswer;
            buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
            audioManager.PlaySFX("Wrong");
        }
    }

    private void SetButtonState(bool state)
    {
        for (int i = 0; i < answerButtons.Length;i++)
        {
            Button button = answerButtons[i].GetComponent<Button>();
            button.interactable = state;
        }
    }

    private void SetDefaultButtonSprite()
    {
        Image buttonImage;
        for (int i = 0; i < answerButtons.Length; i++)
        {
            buttonImage = answerButtons[i].GetComponent<Image>();
            buttonImage.sprite = defaultAnswerSprite;
        }
    }
}

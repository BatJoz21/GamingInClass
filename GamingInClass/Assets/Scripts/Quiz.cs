using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] private QuestionSO question;
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private GameObject[] answerButtons;
    [SerializeField] private Sprite defaultAnswerSprite;
    [SerializeField] private Sprite correctAnswerSprite;

    int correctAnswerIndex;

    void Start()
    {
        DisplayQuestion();
    }

    private void DisplayQuestion()
    {
        questionText.text = question.GetQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

    private void GetNextquestion()
    {
        SetButtonState(true);
        SetDefaultButtonSprite();
        DisplayQuestion();
    }

    public void OnAnswerSelected(int index)
    {
        Image buttonImage;
        if (index == question.GetCorrectAnswerIndex())
        {
            questionText.text += "\n Jawaban anda benar!";
            buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
        else
        {
            correctAnswerIndex = question.GetCorrectAnswerIndex();
            string correctAnswer = question.GetAnswer(correctAnswerIndex);
            questionText.text += "\n Jawaban anda salah! Jawaban yang benar adalah " + correctAnswer;
            buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }

        SetButtonState(false);
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

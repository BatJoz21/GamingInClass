using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private string mataPelajaran;
    [SerializeField] private int kelas;
    [SerializeField] private int level;
    [SerializeField] private Quiz quiz;
    [SerializeField] private EndScreen endScreen;
    [SerializeField] private Scorekeeper scoreKeeper;
    [SerializeField] private GameManager gameManager;

    private int finalScore;
    private AudioManager audioManager;

    public string MataPelajaran { get => mataPelajaran; }
    public int Kelas { get => kelas; }
    public int Level { get => level; }

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    void Start()
    {
        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }

    void Update()
    {
        if (quiz.isComplete)
        {
            audioManager.PlaySFX("Complete");
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
            if (mataPelajaran == "Matematika")
            {
                gameManager.SetMathGrade(kelas, level, scoreKeeper.CalculateScore());
            }
            else if (mataPelajaran == "Bahasa Inggris")
            {
                gameManager.SetEngGrade(kelas, level, scoreKeeper.CalculateScore());
            }
            else if (mataPelajaran == "IPA")
            {
                gameManager.SetSciGrade(kelas, level, scoreKeeper.CalculateScore());
            }
        }
    }
}

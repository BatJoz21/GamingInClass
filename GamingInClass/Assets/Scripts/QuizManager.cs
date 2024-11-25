using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private string mataPelajaran;
    [SerializeField] private int kelas;
    [SerializeField] private int level;
    [SerializeField] private int playerLastGrade;
    [SerializeField] private Quiz quiz;
    [SerializeField] private EndScreen endScreen;
    [SerializeField] private Scorekeeper scoreKeeper;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioManager audioManager;
    [SerializeField] private PlayConfetti confetti;

    private bool hasPlayedAudio = false;
    private bool hasPlayedConfetti = false;

    public string MataPelajaran { get => mataPelajaran; }
    public int Kelas { get => kelas; }
    public int Level { get => level; }

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        audioManager = FindObjectOfType<AudioManager>();
        confetti = FindObjectOfType<PlayConfetti>();
    }

    void Start()
    {
        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
        hasPlayedAudio = false;
        hasPlayedConfetti = false;
    }

    void Update()
    {
        if (quiz.isComplete)
        {
            if (!hasPlayedAudio)
            {
                audioManager.PlaySFX("Complete");
                hasPlayedAudio = true;
            }
            
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
            if (!hasPlayedConfetti)
            {
                confetti.LaunchParticle();
                hasPlayedConfetti = true;
            }         
            playerLastGrade = scoreKeeper.CalculateScore();
            InputGrade(playerLastGrade);
        }
    }

    private void InputGrade(int nilaiPlayer)
    {
        Debug.Log("test");
        if (mataPelajaran == "Matematika")
        {
            gameManager.SetMathGrade(kelas, level, nilaiPlayer);
        }
        else if (mataPelajaran == "Bahasa Inggris")
        {
            gameManager.SetEngGrade(kelas, level, nilaiPlayer);
        }
        else if (mataPelajaran == "IPA")
        {
            gameManager.SetSciGrade(kelas, level, nilaiPlayer);
        }
    }
}

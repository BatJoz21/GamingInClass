using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Start()
    {
        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }

    void Update()
    {
        if (quiz.isComplete)
        {
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

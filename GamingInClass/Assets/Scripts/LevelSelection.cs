using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] gradeText;
    [SerializeField] private int kelas;
    [SerializeField] private string mataPelajaran;

    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        SetGrade();
    }

    public void SetGrade()
    {
        for (int i = 0; i < gradeText.Length; i++)
        {
            if (mataPelajaran == "MATH")
            {
                gradeText[i].text = gameManager.GetMathGrade(kelas, i) + "%";
            }
            else if (mataPelajaran == "ENGLISH")
            {
                gradeText[i].text = gameManager.GetEngGrade(kelas, i) + "%";
            }
            else if (mataPelajaran == "SCIENCE")
            {
                gradeText[i].text = gameManager.GetSciGrade(kelas, i) + "%";
            }
        }
    }
}

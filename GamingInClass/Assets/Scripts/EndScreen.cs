using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI finalScoreText;
    [SerializeField] private Scorekeeper scoreKeeper;

    void Awake()
    {
        //scoreKeeper = FindObjectOfType<Scorekeeper>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "NILAI ANDA = " + scoreKeeper.CalculateScore();
    }
}

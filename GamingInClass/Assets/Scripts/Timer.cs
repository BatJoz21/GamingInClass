using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float answeringTime = 120f;
    [SerializeField] float showAnswerTime = 20f;
    [SerializeField] private bool isAnsweringQuestion = true;

    public float fillFraction;
    public bool loadNextQuestion;

    private float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        if (isAnsweringQuestion) //sedang menjawab pertanyaan
        {
            if (timerValue <= 0) //durasi menjawab pertanyaan habis
            {
                isAnsweringQuestion = false;
                timerValue = showAnswerTime;
            }
            else //durasi menjawab pertanyaan
            {
                fillFraction = timerValue / answeringTime;
            }
        }
        else
        {
            if (timerValue <= 0) //durasi melihat jawaban habis
            {
                isAnsweringQuestion = true;
                timerValue = answeringTime;
                loadNextQuestion = true;
            }
            else //durasi melihat jawaban
            {
                fillFraction = timerValue / showAnswerTime;
            }
        }

        //Debug.Log(isAnsweringQuestion + " " + timerValue + " " + fillFraction);
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    public bool GetIsAnsweringQuestion()
    {
        return isAnsweringQuestion;
    }

    public void SetIsAnsweringQuestion(bool state)
    {
        this.isAnsweringQuestion = state;
    }
}

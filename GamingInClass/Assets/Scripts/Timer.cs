using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float answeringTime = 120f;
    [SerializeField] float showAnswerTime = 20f;

    private bool isAnsweringQuestion = false;
    private float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        if (isAnsweringQuestion)
        {
            if (timerValue <= 0)
            {
                isAnsweringQuestion = false;
                timerValue = showAnswerTime;
            }
        }
        else
        {
            if (timerValue <= 0)
            {
                isAnsweringQuestion = true;
                timerValue = answeringTime;
            }
        }
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

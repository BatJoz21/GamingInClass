using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    private int correctAnswer = 0;
    private int questionSeen = 0;
    
    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswer / (float)questionSeen * 100);
    }

    public int GetCorrectAnswer() {  return correctAnswer; }

    public int GetQuestionSeen() {  return questionSeen; }

    public void IncrementCorrectAnswer()
    {
        this.correctAnswer++;
    }

    public void IncrementQuestionSeen()
    {
        this.questionSeen++;
    }
}

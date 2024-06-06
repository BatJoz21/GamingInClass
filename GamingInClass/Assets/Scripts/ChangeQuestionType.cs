using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeQuestionType : MonoBehaviour
{
    [SerializeField] private int questionTipeEnglish = 0;
    [SerializeField] private int questionTipeMath = 0;
    [SerializeField] private int questionTipeScience = 0;

    public int QuestionTipeEnglish { get => questionTipeEnglish; }
    public int QuestionTipeMath { get => questionTipeMath; }
    public int QuestionTipeScience { get => questionTipeScience; }

    public void ChangeType(int i, string subject)
    {
        if (subject == "English")
        {
            questionTipeEnglish = i;
        }
        else if (subject == "Math")
        {
            questionTipeMath = i;
        }
        else if (subject == "Science")
        {
            questionTipeScience = i;
        }
    }
}

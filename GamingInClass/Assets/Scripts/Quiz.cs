using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] private QuestionSO question;
    [SerializeField] private TextMeshProUGUI questionText;

    void Start()
    {
        questionText.text = question.GetQuestion();
    }

}

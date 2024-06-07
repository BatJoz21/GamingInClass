using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeQuestionType : MonoBehaviour
{
    [SerializeField] private int questionTipeEnglish = 0;
    [SerializeField] private int questionTipeMath = 0;
    [SerializeField] private int questionTipeScience = 0;
    [SerializeField] private GameObject messagePanel;
    [SerializeField] private TextMeshProUGUI messageText;

    public int questionGrade;

    private float timer = 0;

    public int QuestionTipeEnglish { get => questionTipeEnglish; }
    public int QuestionTipeMath { get => questionTipeMath; }
    public int QuestionTipeScience { get => questionTipeScience; }

    void Update()
    {
        MessagePrompt();
    }

    public void ChangeTypeEnglish(int i)
    {
        questionTipeEnglish = i;
        if (i == 0)
        {
            messageText.text = "Tipe soal Bahasa Inggris telah diganti\nTipe soal sekarang: Soal A";
        }
        else if (i == 1)
        {
            messageText.text = "Tipe soal Bahasa Inggris telah diganti\nTipe soal sekarang: Soal B";
        }
        messagePanel.SetActive(true);
    }

    public void ChangeTypeMath(int i)
    {
        questionTipeMath = i;
        if (i == 0)
        {
            messageText.text = "Tipe soal Matematika telah diganti\nTipe soal sekarang: Soal A";
        }
        else if (i == 1)
        {
            messageText.text = "Tipe soal Matematika telah diganti\nTipe soal sekarang: Soal B";
        }
        messagePanel.SetActive(true);
    }

    public void ChangeTypeScience(int i)
    {
        questionTipeScience = i;
        if (i == 0)
        {
            messageText.text = "Tipe soal IPA telah diganti\nTipe soal sekarang: Soal A";
        }
        else if (i == 1)
        {
            messageText.text = "Tipe soal IPA telah diganti\nTipe soal sekarang: Soal B";
        }
        messagePanel.SetActive(true);
    }

    private void MessagePrompt()
    {
        if (messagePanel.gameObject.activeInHierarchy)
        {
            timer = timer + Time.deltaTime;
            if (timer > 2)
            {
                messagePanel.gameObject.SetActive(false);
                timer = 0;
            }
        }
        else
        {
            timer = 0;
        }
    }
}

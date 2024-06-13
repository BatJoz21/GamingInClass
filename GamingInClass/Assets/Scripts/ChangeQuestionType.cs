using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeQuestionType : MonoBehaviour
{
    [SerializeField] private int questionTipeEnglish = 0;
    [SerializeField] private int questionTipeMath = 0;
    [SerializeField] private int questionTipeScience = 0;
    [SerializeField] private int kelasAdmin;
    [SerializeField] private GameObject messagePanel;
    [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private GameManager gameManager;

    private float timer = 0;
    
    public int QuestionTipeEnglish { get => questionTipeEnglish; }
    public int QuestionTipeMath { get => questionTipeMath; }
    public int QuestionTipeScience { get => questionTipeScience; }

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        FindGameManager();
        MessagePrompt();
    }

    private void FindGameManager()
    {
        if (gameManager == null)
        {
            gameManager = FindObjectOfType<GameManager>();
        }
    }

    public void ChangeTypeEnglish(int i)
    {
        questionTipeEnglish = i;
        if (kelasAdmin == 1)
        {
            gameManager.QuestionTypeEnglish1 = questionTipeEnglish;
        }
        else if (kelasAdmin == 2)
        {
            gameManager.QuestionTypeEnglish2 = questionTipeEnglish;
        }
        else if (kelasAdmin == 3)
        {
            gameManager.QuestionTypeEnglish3 = questionTipeEnglish;
        }

        //Message Prompt
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
        if (kelasAdmin == 1)
        {
            gameManager.QuestionTypeMath1 = questionTipeMath;
        }
        else if (kelasAdmin == 2)
        {
            gameManager.QuestionTypeMath2 = questionTipeMath;
        }
        else if (kelasAdmin == 3)
        {
            gameManager.QuestionTypeMath3 = questionTipeMath;
        }

        //Message Prompt
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
        if (kelasAdmin == 1)
        {
            gameManager.QuestionTypeScience1 = questionTipeScience;
        }
        else if (kelasAdmin == 2)
        {
            gameManager.QuestionTypeScience2 = questionTipeScience;
        }
        else if (kelasAdmin == 3)
        {
            gameManager.QuestionTypeScience3 = questionTipeScience;
        }

        //Message Prompt
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

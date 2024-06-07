using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Kelas 1")]
    [SerializeField] private int questionTypeEnglish1 = 0;
    [SerializeField] private int questionTypeMath1 = 0;
    [SerializeField] private int questionTypeScience1 = 0;
    [SerializeField] private int[] math1;
    [SerializeField] private int[] eng1;
    [SerializeField] private int[] sci1;

    [Header("Kelas 2")]
    [SerializeField] private int questionTypeEnglish2 = 0;
    [SerializeField] private int questionTypeMath2 = 0;
    [SerializeField] private int questionTypeScience2 = 0;
    [SerializeField] private int[] math2;
    [SerializeField] private int[] eng2;
    [SerializeField] private int[] sci2;

    [Header("Kelas 3")]
    [SerializeField] private int questionTypeEnglish3 = 0;
    [SerializeField] private int questionTypeMath3 = 0;
    [SerializeField] private int questionTypeScience3 = 0;
    [SerializeField] private int[] math3;
    [SerializeField] private int[] eng3;
    [SerializeField] private int[] sci3;
        
    private static GameManager instance;
    private ChangeQuestionType changeQuestionType;

    //Grade 1 Encapsulation
    public int QuestionTypeEnglish1 { get => questionTypeEnglish1; }
    public int QuestionTypeMath1 { get => questionTypeMath1; }
    public int QuestionTypeScience1 { get => questionTypeScience1; }

    //Grade 2 Encapsulation
    public int QuestionTypeEnglish2 { get => questionTypeEnglish2; }
    public int QuestionTypeMath2 { get => questionTypeMath2; }
    public int QuestionTypeScience2 { get => questionTypeScience2; }

    //Grade 3 Encapsulation
    public int QuestionTypeEnglish3 { get => questionTypeEnglish3; }
    public int QuestionTypeMath3 { get => questionTypeMath3; }
    public int QuestionTypeScience3 { get => questionTypeScience3; }

    void Awake()
    {
        ManageGameInstance();
        changeQuestionType = FindObjectOfType<ChangeQuestionType>();
    }

    void Update()
    {
        QuestionTypeSetting();
    }

    private void ManageGameInstance()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void QuestionTypeSetting()
    {
        if (changeQuestionType != null)
        {
            if (changeQuestionType.questionGrade == 1)
            {
                questionTypeEnglish1 = changeQuestionType.QuestionTipeEnglish;
                questionTypeMath1 = changeQuestionType.QuestionTipeMath;
                questionTypeScience1 = changeQuestionType.QuestionTipeScience;
            }
            else if (changeQuestionType.questionGrade == 2)
            {
                questionTypeEnglish2 = changeQuestionType.QuestionTipeEnglish;
                questionTypeMath2 = changeQuestionType.QuestionTipeMath;
                questionTypeScience2 = changeQuestionType.QuestionTipeScience;
            }
            else if (changeQuestionType.questionGrade == 3)
            {
                questionTypeEnglish3 = changeQuestionType.QuestionTipeEnglish;
                questionTypeMath3 = changeQuestionType.QuestionTipeMath;
                questionTypeScience3 = changeQuestionType.QuestionTipeScience;
            }
        }
    }

    //Get Nilai

    public int GetMathGrade(int kelas, int level)
    {
        if (kelas == 1)
        {
            return math1[level];
        }
        else if (kelas == 2)
        {
            return math2[level];
        }
        else if (kelas == 3)
        {
            return math3[level];
        }
        else
        {
            return 0;
        }
    }

    public int GetEngGrade(int kelas, int level)
    {
        if (kelas == 1)
        {
            return eng1[level];
        }
        else if (kelas == 2)
        {
            return eng2[level];
        }
        else if (kelas == 3)
        {
            return eng3[level];
        }
        else
        {
            return 0;
        }
    }

    public int GetSciGrade(int kelas, int level)
    {
        if (kelas == 1)
        {
            return sci1[level];
        }
        else if (kelas == 2)
        {
            return sci2[level];
        }
        else if (kelas == 3)
        {
            return sci3[level];
        }
        else
        {
            return 0;
        }
    }

    //Set Nilai
    public void SetMathGrade(int kelas, int level, int nilai)
    {
        if (kelas == 1)
        {
            math1[level - 1] = nilai;
        }
        else if (kelas == 2)
        {
            math2[level - 1] = nilai;
        }
        else if (kelas == 3)
        {
            math2[level - 1] = nilai;
        }
    }

    public void SetEngGrade(int kelas, int level, int nilai)
    {
        if (kelas == 1)
        {
            eng1[level - 1] = nilai;
        }
        else if (kelas == 2)
        {
            eng2[level - 1] = nilai;
        }
        else if (kelas == 3)
        {
            eng2[level - 1] = nilai;
        }
    }

    public void SetSciGrade(int kelas, int level, int nilai)
    {
        if (kelas == 1)
        {
            sci1[level - 1] = nilai;
        }
        else if (kelas == 2)
        {
            sci2[level - 1] = nilai;
        }
        else if (kelas == 3)
        {
            sci2[level - 1] = nilai;
        }
    }
}

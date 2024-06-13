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

    //Grade 1 Encapsulation
    public int QuestionTypeEnglish1 { get => questionTypeEnglish1; set => questionTypeEnglish1 = value; }
    public int QuestionTypeMath1 { get => questionTypeMath1; set => questionTypeMath1 = value; }
    public int QuestionTypeScience1 { get => questionTypeScience1; set => questionTypeScience1 = value; }

    //Grade 2 Encapsulation
    public int QuestionTypeEnglish2 { get => questionTypeEnglish2; set => questionTypeEnglish2 = value; }
    public int QuestionTypeMath2 { get => questionTypeMath2; set => questionTypeMath2 = value; }
    public int QuestionTypeScience2 { get => questionTypeScience2; set => questionTypeScience2 = value; }

    //Grade 3 Encapsulation
    public int QuestionTypeEnglish3 { get => questionTypeEnglish3; set => questionTypeEnglish3 = value; }
    public int QuestionTypeMath3 { get => questionTypeMath3; set => questionTypeMath3 = value; }
    public int QuestionTypeScience3 { get => questionTypeScience3; set => questionTypeScience3 = value; }

    void Awake()
    {
        ManageGameInstance();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Kelas 1")]
    [SerializeField] private int[] math1;
    [SerializeField] private int[] eng1;
    [SerializeField] private int[] sci1;

    [Header("Kelas 2")]
    [SerializeField] private int[] math2;
    [SerializeField] private int[] eng2;
    [SerializeField] private int[] sci2;

    [Header("Kelas 3")]
    [SerializeField] private int[] math3;
    [SerializeField] private int[] eng3;
    [SerializeField] private int[] sci3;

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
            math1[level] = nilai;
        }
        else if (kelas == 2)
        {
            math2[level] = nilai;
        }
        else if (kelas == 3)
        {
            math2[level] = nilai;
        }
    }

    public void SetEngGrade(int kelas, int level, int nilai)
    {
        if (kelas == 1)
        {
            eng1[level] = nilai;
        }
        else if (kelas == 2)
        {
            eng2[level] = nilai;
        }
        else if (kelas == 3)
        {
            eng2[level] = nilai;
        }
    }

    public void SetSciGrade(int kelas, int level, int nilai)
    {
        if (kelas == 1)
        {
            sci1[level] = nilai;
        }
        else if (kelas == 2)
        {
            sci2[level] = nilai;
        }
        else if (kelas == 3)
        {
            sci2[level] = nilai;
        }
    }
}

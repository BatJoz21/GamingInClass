using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        this.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void OpeningOptions()
    {
        this.gameObject.SetActive(true);
    }

    public void ExitingOptions()
    {
        this.gameObject.SetActive(false);
    }
}

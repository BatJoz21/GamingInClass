using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsBehavior : MonoBehaviour
{
    [SerializeField] private Options optionCanvas;

    void Awake()
    {
        optionCanvas = FindObjectOfType<Options>();
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenOptionPanel()
    {
        optionCanvas.OpenOptionPanel();
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

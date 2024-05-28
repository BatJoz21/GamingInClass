using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsBehavior : MonoBehaviour
{
    [SerializeField] private Options optionCanvas;
    [SerializeField] private AdminScript adm;

    void Awake()
    {
        optionCanvas = FindObjectOfType<Options>();
        adm = FindObjectOfType<AdminScript>();
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenOptionPanel()
    {
        if (optionCanvas != null)
        {
            optionCanvas.OpenOptionPanel();
        }
    }

    public void OpenAdminLogin()
    {
        if (adm != null)
        {
            adm.ActivatePanel();
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

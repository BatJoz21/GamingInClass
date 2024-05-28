using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class AdminScript : MonoBehaviour
{
    [SerializeField] private string id_val;
    [SerializeField] private string pass_val;
    [SerializeField] private GameObject adminPanel;

    private string userId;
    private string userPass;

    public void EnterId(string val)
    {
        userId = val;
    }

    public void EnterPass(string val)
    {
        userPass = val;
    }

    public void EnterAdminPage()
    {
        if (userId == id_val && userPass == pass_val)
        {
            SceneManager.LoadScene("Admin Main Menu");
        }
    }

    public void ActivatePanel()
    {
        adminPanel.SetActive(true);
    }

    public void BackToUserSelection()
    {
        adminPanel.SetActive(false);
    }
}

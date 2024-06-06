using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Options : MonoBehaviour
{
    [SerializeField] private GameObject optionPanel;
    [SerializeField] private Toggle muteToogle;
    [SerializeField] private Slider sliderBGM;
    [SerializeField] private Slider sliderSFX;
    [SerializeField] private TextMeshProUGUI bgmVolText;
    [SerializeField] private TextMeshProUGUI sfxVolText;

    private AudioManager audioManager;
    private static Options instance;

    void Awake()
    {
        ManageOptions();
    }

    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        GetVolumeSlider();
    }

    void Update()
    {
        GetVolumeTxt();
    }

    private void ManageOptions()
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

    public void GetVolumeTxt()
    {
        float temp1 = audioManager.GetBGMVol() * 100;
        float temp2 = audioManager.GetSFXVol() * 100;

        string bgmVol = temp1.ToString();
        string sfxVol = temp2.ToString();
        bgmVolText.text = bgmVol;
        sfxVolText.text = sfxVol;
    }

    public void GetVolumeSlider()
    {
        sliderBGM.value = audioManager.GetBGMVol();
        sliderSFX.value = audioManager.GetSFXVol();
    }

    public void SetMuteToggle()
    {
        bool con = muteToogle.isOn;
        if (con)
        {
            audioManager.SetMute(true);
        }
        else
        {
            audioManager.SetMute(false);
        }
    }

    public void SetUpBGM()
    {
        float sliderVal = sliderBGM.value;
        audioManager.SetVolumeBGM(sliderVal);
    }

    public void SetUpSFX()
    {
        float sliderVal = sliderSFX.value;
        audioManager.SetVolumeSFX(sliderVal);
    }

    public void OpenOptionPanel()
    {
        optionPanel.SetActive(true);
    }

    public void CloseOptionPanel()
    {
        optionPanel.SetActive(false);
    }
}
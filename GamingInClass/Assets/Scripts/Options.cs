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

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
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

    public void GetVolumeTxt()
    {
        string bgmVol = audioManager.GetBGMVol().ToString();
        string sfxVol = audioManager.GetSFXVol().ToString();
        bgmVolText.text = bgmVol;
        sfxVolText.text = sfxVol;
    }

    public void GetVolumeSlider()
    {
        sliderBGM.value = audioManager.GetBGMVol() / 100;
        sliderSFX.value = audioManager.GetSFXVol() / 100;
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource bgm;
    [SerializeField] private AudioSource sfxCorrectAnswer;
    [SerializeField] private AudioSource sfxWrongAnswer;
    [SerializeField] private AudioSource sfxLevelComplete;

    private Options options;
    private static AudioManager instance;

    void Awake()
    {
        ManageAudioManager();
    }

    void Start()
    {
        options = FindObjectOfType<Options>();
    }

    private void ManageAudioManager()
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

    public void PlaySFX(string val)
    {
        if (val == "Correct")
        {
            sfxCorrectAnswer.Play();
        }
        else if (val == "Wrong")
        {
            sfxWrongAnswer.Play();
        }
        else if (val == "Complete")
        {
            sfxLevelComplete.Play();
        }
    }

    public void SetMute(bool val)
    {
        bgm.mute = val;
        sfxCorrectAnswer.mute = val;
        sfxWrongAnswer.mute = val;
        sfxLevelComplete.mute = val;
    }

    public void SetVolumeBGM(float vol)
    {
        bgm.volume = vol;
    }

    public void SetVolumeSFX(float vol)
    {
        sfxCorrectAnswer.volume = vol;
        sfxWrongAnswer.volume = vol;
        sfxLevelComplete.volume = vol;
    }

    public float GetBGMVol()
    {
        return bgm.volume;
    }

    public float GetSFXVol()
    {
        return sfxCorrectAnswer.volume;
    }
}

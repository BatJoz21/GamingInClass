using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource bgm;
    [SerializeField] private AudioSource sfx;

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

    public void SetMute(bool val)
    {
        bgm.mute = val;
        sfx.mute = val;
    }

    public void SetVolumeBGM(float vol)
    {
        bgm.volume = vol;
    }

    public void SetVolumeSFX(float vol)
    {
        sfx.volume = vol;
    }

    public int GetBGMVol()
    {
        return Mathf.RoundToInt(bgm.volume * 100);
    }

    public int GetSFXVol()
    {
        return Mathf.RoundToInt(sfx.volume * 100);
    }
}

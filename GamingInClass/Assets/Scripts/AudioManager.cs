using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource bgm;
    [SerializeField] private AudioSource sfx;

    private Options options;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        options = FindObjectOfType<Options>();
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

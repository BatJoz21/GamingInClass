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

    public void SetMute(bool mute)
    {
        bgm.mute = mute;
        sfx.mute = mute;
    }

    public void SetVolumeBGM(int vol)
    {
        bgm.volume = vol / 100;
    }

    public void SetVolumeSFX(int vol)
    {
        sfx.volume = vol / 100;
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

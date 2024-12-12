using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayConfetti : MonoBehaviour
{
    [SerializeField] ParticleSystem[] particleSystems;

    public void LaunchParticle()
    {
        if (!particleSystems[0].isPlaying)
        {
            particleSystems[0].Play();
        }
        if (!particleSystems[1].isPlaying)
        {
            particleSystems[1].Play();
        }
        if (!particleSystems[2].isPlaying)
        {
            particleSystems[2].Play();
        }
        if (!particleSystems[3].isPlaying)
        {
            particleSystems[3].Play();
        }
    }
}

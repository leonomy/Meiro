using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip mapClip;
    public AudioClip watchClip;
    public AudioClip warpPointClip;
    public AudioClip hourglassClip;
    public AudioClip goalClip;

    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    public void PlayMapClip()
    {
        GetComponent<AudioSource>().PlayOneShot(mapClip);
    }

    public void PlayWatchClip()
    {
        GetComponent<AudioSource>().PlayOneShot(watchClip);
    }

    public void PlayWarpPointClip()
    {
        GetComponent<AudioSource>().PlayOneShot(warpPointClip);
    }

    public void PlayHourglassClip()
    {
        GetComponent<AudioSource>().PlayOneShot(hourglassClip);
    }

    public void PlayGoalClip()
    {
        GetComponent<AudioSource>().PlayOneShot(goalClip);
    }
}

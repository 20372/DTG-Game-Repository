using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeSound : MonoBehaviour
{
    public AudioSource backgroundsounds;
    public AudioSource healthloss;
    public AudioSource speedReset;

    private void Start()
    {
        playBackground();
    }
    public void playBackground()
    {
        backgroundsounds.Play();
    }
    public void playHealthLose()
    {
        healthloss.Play();
    }
    public void playSpeedReset()
    {
        speedReset.Play();
    }
}

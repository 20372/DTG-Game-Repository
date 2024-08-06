using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeSound : MonoBehaviour
{
    public AudioSource backgroundsounds;
    public AudioSource healthloss;
    public AudioSource speedUpSound;
    public AudioSource slowDownSound;
    public AudioSource jumpSound;

    private void Start()
    {
        playBackGroundMusic();
    }
    public void playBackGroundMusic()
    {
        backgroundsounds.Play();
    }
    public void playHealthLose()
    {
        healthloss.Play();
    }
    public void playSpeedReset()
    {
        speedUpSound.Play();
    }

    public void playSlowDown()
    {
        slowDownSound.Play();
    }

    public void playJump()
    {
        jumpSound.Play(); 
    }
}

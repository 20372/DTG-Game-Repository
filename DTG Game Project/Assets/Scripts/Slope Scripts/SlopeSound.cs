using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeSound : MonoBehaviour
{
    public AudioSource backgroundsounds;
    public AudioSource healthloss;
    public AudioSource speedUpSound;
    public AudioSource slowDownSound;
    public AudioSource jumpSound; //Audio for slope gmaw 

    private void Start()
    {
        playBackGroundMusic();
    }
    public void playBackGroundMusic() //Function that plays each audio when called 
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

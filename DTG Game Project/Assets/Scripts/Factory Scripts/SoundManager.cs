using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioSource> sounds; //List of everySound used in this scene

    private void Awake()
    {
        LowWalkingSound();
    }
    public void DamageSound() //Function that plays each one 
    {
        sounds[0].Play();
    }

    public void HealSound()
    {
        sounds[1].Play();
    }

    public void LowWalkingSound()
    {
        sounds[2].Play();
    }
    public void DoorOpenSound()
    {
        sounds[3].Play();
    }
    public void DoorCloseSound()
    {
        sounds[4].Play();
    }
}

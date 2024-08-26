using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioSource> sounds;

    private void Awake()
    {
        LowWalkingSound();
    }
    public void DamageSound()
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

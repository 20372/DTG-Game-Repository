using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioSource> sounds;

    public void DamageSound()
    {
        sounds[0].Play();
    }

    public void HealSound()
    {
        sounds[1].Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitPlaySounds : MonoBehaviour
{

    public AudioSource incorrectSound;
    public AudioSource correctSound;
    public AudioSource selectSound;
    public AudioSource placeSound;
    public void incorrect()
    {
        incorrectSound.Play();
    }

    public void correct()
    {
        correctSound.Play();
    }

    public void select ()
    {
        selectSound.Play();
    }

    public void place()
    {
        placeSound.Play();
    }


}


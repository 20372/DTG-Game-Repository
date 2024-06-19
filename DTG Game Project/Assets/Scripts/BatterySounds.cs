using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BatterySounds : MonoBehaviour
{
    public AudioSource electric;
    public AudioSource heal;
    public void Sound_Damage()
    {
        electric.Play();
    }

    public void Sound_Heal()
    {
        heal.Play();
    }
}

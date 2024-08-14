using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public DoorAnimations doorAnimations;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("TOTOTOT");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("123");
            doorAnimations.OpenDoor();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThridDoorTrigger : MonoBehaviour
{
    public ThridDoor thridDoor;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            thridDoor.OpenDoor();
        }
    }
}

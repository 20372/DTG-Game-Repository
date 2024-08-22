using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCloseDoor : MonoBehaviour
{

    [SerializeField] private DoorAnimations doorAnimations;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            doorAnimations.CloseDoor();
        }
     
    }
}

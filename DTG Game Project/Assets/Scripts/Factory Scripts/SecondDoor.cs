using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoor : MonoBehaviour
{
    public Animator anim;

    public void Start()
    {
        
    }
    public void OpenDoor()
    {
        anim.Play("RealDoorOpen");
    }
    public void CloseDoor()
    {
        anim.Play("RealDoorClose");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            CloseDoor();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoor : MonoBehaviour
{
    public Animator anim;

    public void OpenDoor()
    {
        anim.Play("RealDoorOpen");
    }
    public void CloseDoor()
    {
        anim.Play("RealOpenClose");
    }
}

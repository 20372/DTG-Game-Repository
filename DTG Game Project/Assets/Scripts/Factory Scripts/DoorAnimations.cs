using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimations : MonoBehaviour
{

    [SerializeField] private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("OpenDoor", true);
        anim.SetBool("Start", false);
    }

    public void OpenDoor()
    {
        anim.SetBool("Start", true);
        anim.SetBool("OpenDoor", true);
    }
    public void CloseDoor()
    {
        anim.SetBool("OpenDoor", false);
    }
    
}

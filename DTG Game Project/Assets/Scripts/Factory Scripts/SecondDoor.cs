using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoor : MonoBehaviour
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
        Debug.Log("Open Second DOor");
        anim.SetBool("OpenDoor", true);
        anim.SetBool("Start", true);
    }
    public void CloseDoor()
    {
        anim.SetBool("OpenDoor", false);
        anim.SetBool("Start", true);
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CloseDoor();
        }
    }
}

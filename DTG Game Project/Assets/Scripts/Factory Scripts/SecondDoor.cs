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
        StartCoroutine(Wait(1f));
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

    IEnumerator Wait(float WaitTime)
    {
        yield return new WaitForSeconds(WaitTime);
        anim.SetBool("OpenDoor", true);
        anim.SetBool("Start", true);
    }
}

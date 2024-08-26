using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoor : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private SoundManager soundManager;
    public bool isPlayingOpen;
    public bool isPlayingClose;

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
            if (isPlayingClose == false)
            {
                soundManager.DoorCloseSound();
                isPlayingClose = true;
            }
            CloseDoor();
        }
    }

    IEnumerator Wait(float WaitTime)
    {
        yield return new WaitForSeconds(WaitTime);
        if (isPlayingOpen == false)
        {
            soundManager.DoorOpenSound();
            isPlayingOpen = true;
        }
        anim.SetBool("OpenDoor", true);
        anim.SetBool("Start", true);
    }
}

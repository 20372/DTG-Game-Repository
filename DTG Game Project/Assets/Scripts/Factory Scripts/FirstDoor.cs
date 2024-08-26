using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDoor : MonoBehaviour
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
        isPlayingOpen = false;
        isPlayingClose = false;
    }

    public void OpenDoor()
    {
        if(isPlayingOpen == false)
        {
            soundManager.DoorOpenSound();
            isPlayingOpen = true;
        }
        anim.SetBool("OpenDoor", true);
        anim.SetBool("Start", true);
    }
    public void CloseDoor()
    {
        if (isPlayingClose == false)
        {
            soundManager.DoorCloseSound();
            isPlayingClose = true;
        }
        anim.SetBool("OpenDoor", false);
        anim.SetBool("Start", true);
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            CloseDoor();
        }
    }
}

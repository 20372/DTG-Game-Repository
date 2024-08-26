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
        isPlayingOpen = false; //Starting Values 
        isPlayingClose = false;
    }

    public void OpenDoor()
    {
        if(isPlayingOpen == false) //This if is used to ensure DoorOpenSound only plays 1 time 
        {
            soundManager.DoorOpenSound();
            isPlayingOpen = true;
        }
        anim.SetBool("OpenDoor", true);
        anim.SetBool("Start", true); //Updates Bool on Animator Componet 
    }
    public void CloseDoor()
    {
        if (isPlayingClose == false) //This if is used to ensure DoorCloseSound only plays 1 time 
        {
            soundManager.DoorCloseSound();
            isPlayingClose = true;
        }
        anim.SetBool("OpenDoor", false); //Plays Closing Animation 
        anim.SetBool("Start", true);
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            CloseDoor(); //if player runs through door close it behind them
        }
    }
}

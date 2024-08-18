using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{

    public bool redPlatform;
    public bool bluePlatform;
    public bool multiPlatform;
    public bool concretePlatform;
    public DoorAnimations doorAnimations;
    // Start is called before the first frame update
    void Start()
    {
        redPlatform = false;
        bluePlatform = false;
        multiPlatform = false;
        concretePlatform = false;
    }

    void LateUpdate()
    {
        if (redPlatform == true & bluePlatform == true & multiPlatform == true & concretePlatform == true)
        {
            doorAnimations.OpenDoor();
        }
    }
}

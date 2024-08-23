using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{

    public bool redPlatform;
    public bool bluePlatform;
    public bool multiPlatform;
    public bool concretePlatform;
    public FirstDoor firstDoor;
    // Start is called before the first frame update
    void Start()
    {
        redPlatform = true;
        bluePlatform = true;
        multiPlatform = true;
        concretePlatform = true;
    }

    void LateUpdate()
    {
        if (redPlatform == true & bluePlatform == true & multiPlatform == true & concretePlatform == true)
        {
            firstDoor.OpenDoor();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{

    public bool redPlatform;
    public bool bluePlatform; //Platforms bools 
    public bool multiPlatform;
    public bool concretePlatform;
    public FirstDoor firstDoor;
    // Start is called before the first frame update
    void Start()
    {
        redPlatform = false;
        bluePlatform = false; //Sets their starting value 
        multiPlatform = false;
        concretePlatform = false;
    }

    void LateUpdate()
    {
        if (redPlatform == true & bluePlatform == true & multiPlatform == true & concretePlatform == true)
        {
            firstDoor.OpenDoor(); //If all equal true opens first door 
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    private bool isConcrete = false;
    private bool isBlue = false;
    private bool isRed = false;
    private bool isMulti = false;
    private int activeBool = 0;
    [SerializeField] private BirdManager birdManager;

    private void Start()
    {
        if (this.gameObject.CompareTag("Concrete"))
        {
            isConcrete = true;
            activeBool = 1;
        }
        if (this.gameObject.CompareTag("Red"))
        {
            isRed = true;
            activeBool = 2;
        }
        if (this.gameObject.CompareTag("Blue"))
        {
            isBlue = true;
            activeBool = 3;
        }
        if (this.gameObject.CompareTag("Multi"))
        {
            isMulti = true;
            activeBool = 4;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Concrete") & isConcrete == true)
        {
            birdManager.concretePlatform = true;
        }
        if (collision.gameObject.CompareTag("Red") & isRed == true)
        {
            birdManager.redPlatform = true;
        }
        if (collision.gameObject.CompareTag("Blue") & isBlue == true)
        {
            birdManager.bluePlatform = true;
        }
        if (collision.gameObject.CompareTag("Multi") & isMulti == true)
        {
            birdManager.multiPlatform = true;
        }
       
    }
}

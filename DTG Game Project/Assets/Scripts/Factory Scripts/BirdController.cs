using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    private bool isConcrete = false;
    private bool isBlue = false;
    private bool isRed = false;
    private bool isMulti = false;
    [SerializeField] private BirdManager birdManager;

    private void Start()
    {
        if (this.gameObject.CompareTag("Concrete"))
        {
            isConcrete = true;
        }
        if (this.gameObject.CompareTag("Red"))
        {
            isRed = true;
        }
        if (this.gameObject.CompareTag("Blue"))
        {
            isBlue = true;
        }
        if (this.gameObject.CompareTag("Multi"))
        {
            isMulti = true;
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

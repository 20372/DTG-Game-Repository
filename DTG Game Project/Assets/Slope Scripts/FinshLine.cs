using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinshLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You Completed this MiniGame");
            //Show UI to player
            //Send em back 
        }
    }
}

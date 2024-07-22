using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCOde : MonoBehaviour
{
    public GoldManager goldManager;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            goldManager.GoldFound(); // Calls this function to update the gold float and change the UI
            Destroy(gameObject); //destroys Gold when player collides with them

        }
    }

}




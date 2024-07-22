using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDEAD : MonoBehaviour
{

    public GameObject Skel;
    public int Health;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("DEWAD");
        } 
        if (collision.CompareTag("Sword")) //updates health when it takes damage
        {
            Health = Health - 1;
        }
        


    }

    private void Update()
    {
        if (Health ==  0)
        {
            Debug.Log("Enemyt DEad");
            Destroy(Skel); //Destory Skeleton when it runs out of health 
        }
    }
}


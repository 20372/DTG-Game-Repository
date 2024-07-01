using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidTrigger : MonoBehaviour
{
    public GameObject player;
    public SlopeHealth slopeHealth;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            player.transform.position = new Vector3(0, 0.87f, -250);
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            slopeHealth.TakeDamage();
        }
    }
}

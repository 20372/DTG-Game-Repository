using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitLaser : MonoBehaviour
{
    [SerializeField] private HealthManager healthManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            healthManager.DealDamage(20f); //If player collides with laser takes damage
        }
    }
}

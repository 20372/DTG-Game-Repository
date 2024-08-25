using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    [SerializeField] private HealthManager healthManager;
    private bool canHeal;

    private void Start()
    {
        canHeal = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && healthManager.healthAmount < 100 && canHeal == true)
        {
            healthManager.StartHealing();
            StartCoroutine(Wait3Seconds());
        }
    }
    IEnumerator Wait3Seconds()
    {
        yield return new WaitForSeconds(3f);
        this.gameObject.SetActive(false);
        canHeal = false;
    }
}

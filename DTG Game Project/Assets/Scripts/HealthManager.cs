using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public float healthAmount;
    public float healthMax;
    public Image healthBar;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            DealDamage(20);
        }
        if (Input.GetKeyDown("r"))
        {
            Heal(20);
        }
        if (healthAmount <= 0)
        {
            Debug.Log("You died");
        }
    }

    public void DealDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healing)
    {
        healthAmount += healing;
        healthAmount = Mathf.Clamp(healthAmount, 0, healthMax);
        healthBar.fillAmount = healthAmount / 100f;
    }
}

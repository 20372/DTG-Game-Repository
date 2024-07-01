using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public float healthAmount;
    public float healthMax;
    public Image healthBar;
    public BatteryColorChage batteryColorChage;
    public BatterySounds batterySounds;
    public HealTimer healTimer;

    
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            DealDamage(20);
            batteryColorChage.ChangeBatteryRed();
            batterySounds.Sound_Damage();
        }
        if (Input.GetKeyDown("r"))
        {
          
            healTimer.StartHealing();
            StartCoroutine(Wait3());
        }
        if (healthAmount <= 0)
        {
            Debug.Log("You died");
        }
    }

    public void ResetHealthAmount(float amount)
    {
        healthBar.fillAmount = amount / 100f;
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

    public IEnumerator Wait3()
    {
        yield return new WaitForSeconds(3f);
        Heal(20);
        batteryColorChage.ChangeBatteryGold();
        batterySounds.Sound_Heal();
    }
}

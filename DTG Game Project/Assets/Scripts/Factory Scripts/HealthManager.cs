using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public GameObject GameOverUI;
    //Health Manager Variables 
    public float healthAmount;
    public float healthMax;
    public Image healthBar;
    public SoundManager soundManager;
 
    //Healing Circle Animation Variables 
    public Image circleImg;
    public TextMeshProUGUI text;
    public Image BackImg;
    public int TimeCircle;
    private int remainingTime;
    private float currentFillAmount;
    private float updateInterval = 0.05f;
    private float decrementAmount = 0f;

    //Battery OutLine Colour Change Variables 
    public Image batteryIMG;
    public Color red = new Color(0, 0, 0);
    public Color gold = new Color(0, 0, 0);

    //Battery Gradual Colour Change Variables
    public Image batImg;
    public Image backgroundBatImg;
    public Color Blue = new Color(139, 198, 252);
    public Color Purple = new Color(0, 255, 0);
    public Color Red = new Color(139, 198, 252);
    public Color Red1 = new Color(255, 255, 255);
    public float switchDuration = 1f;

    private void Start()
    {
        text.enabled = false; //Sets Cirle UI to false at start
        circleImg.enabled = false;
        BackImg.enabled = false;
    }

    //------------------------
    //Health Manager Functions
    //------------------------
   
    private void LateUpdate()
    {
        batImg.color = Color.Lerp(Blue, Purple, Mathf.PingPong(Time.time / switchDuration, 1));
        backgroundBatImg.color = Color.Lerp(Red, Red1, Mathf.PingPong(Time.time / switchDuration, 1));
    }
    public void ResetHealthAmount(float amount)
    {
        healthBar.fillAmount = amount / 100f;
    }
    public void DealDamage(float damage)
    {
        healthAmount -= damage;
        if (healthAmount <=  0)
        {
            GameOverUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        healthBar.fillAmount = healthAmount / 100f;
        ChangeBatteryRed();
        soundManager.DamageSound();
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
        ChangeBatteryGold();
        soundManager.HealSound();
    }

    //--------------------------
    //Healing Animation Functions 
    //--------------------------
    public void StartHealing()
    {
        text.enabled = true;
        circleImg.enabled = true;
        BackImg.enabled = true;
        remainingTime = TimeCircle;
        currentFillAmount = 1.0f;
        StartCoroutine(UpdateTimer());
        StartCoroutine(Wait3());
    }
    void HealingOver()
    {
        text.enabled = false;
        circleImg.enabled = false;
        BackImg.enabled = false;
    }

    public IEnumerator UpdateTimer()
    {
        decrementAmount = 1.0f / (TimeCircle / updateInterval);

        while (remainingTime > 0)
        {
            yield return new WaitForSeconds(updateInterval);

            currentFillAmount -= decrementAmount;
            circleImg.fillAmount = currentFillAmount;

            text.text = $"{remainingTime}";

            if (currentFillAmount <= Mathf.InverseLerp(0, TimeCircle, remainingTime - 1))
            {
                remainingTime--;
            }
        }
        text.text = "0";
        circleImg.fillAmount = 0;
        HealingOver();
    }
    //------------------------------
    //BatteryOutLINEColorChange Functions 
    //-----------------------------
    public void ChangeBatteryRed()
    {
        batteryIMG.color = red; //Changes Colour to red for 0.4 seconds
        StartCoroutine(Wait());
    }
    public void ChangeBatteryGold()
    {
        batteryIMG.color = gold;  //Changes Colour to gold for 0.4 seconds
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.4f);
        batteryIMG.color = new Color(255, 255, 255); //Resets Colour back
    }
   
}

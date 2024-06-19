using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealTimer : MonoBehaviour
{
    public Image img;
    public TextMeshProUGUI text;
    public Image BackImg;

    public int Time;
    private int remainingTime;
    private float currentFillAmount;
    private float updateInterval = 0.05f;
    private float decrementAmount = 0f;

    private void Start()
    {
        text.enabled = false;
        img.enabled = false;
        BackImg.enabled = false;

    }
    public void StartHealing()
    {
        text.enabled = true;
        img.enabled = true;
        BackImg.enabled = true;
        remainingTime = Time;
        currentFillAmount = 1.0f;
        StartCoroutine(UpdateTimer());
    }
    void HealingOver()
    {
        text.enabled = false;
        img.enabled = false;
        BackImg.enabled = false;
        //Call healing function
        //Hide healing UI
        //Del charging object
    }
    public IEnumerator UpdateTimer()
    {
       decrementAmount = 1.0f / (Time / updateInterval);

        while (remainingTime > 0)
        {
            yield return new WaitForSeconds(updateInterval);

            currentFillAmount -= decrementAmount;
            img.fillAmount = currentFillAmount;

            text.text = $"{remainingTime}";

            if (currentFillAmount <= Mathf.InverseLerp(0, Time, remainingTime - 1))
            {
                remainingTime--;
            }
        }
        text.text = "0";
        img.fillAmount = 0;
        HealingOver();
    }
    
}

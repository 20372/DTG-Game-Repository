using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BatteryColorChage : MonoBehaviour
{
    public Image batteryIMG;
    public Color red = new Color(0, 0, 0);
    public Color gold = new Color(0, 0, 0);

    public void ChangeBatteryRed()
    {
        batteryIMG.color = red;

        StartCoroutine(Wait());
        
    }

    public void ChangeBatteryGold()
    {
        batteryIMG.color = gold;

        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.4f);
        batteryIMG.color = new Color(255, 255, 255);
    }
}

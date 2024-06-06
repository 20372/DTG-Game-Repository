using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI UITimeLeft;
    public int TimeLeft = 100;

    void Start()
    {
        InvokeRepeating("TimerChange", 1f, 1f);
    }

    void TimerChange()
    {
        TimeLeft = TimeLeft - 1;
        UITimeLeft.text = "Time Left - " + TimeLeft + "s";
        if (TimeLeft == 0)
        {
            Debug.Log("User Run out of time");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float level;
    public TextMeshProUGUI UITimeLeft;
    private int TimeLeft = 100;

    void Start()
    {
        TimeLeft = (int)(100 * level) + 1;
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

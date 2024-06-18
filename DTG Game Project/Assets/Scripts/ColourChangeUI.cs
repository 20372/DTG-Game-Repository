using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChangeUI : MonoBehaviour
{
    public Image img;
    public Color from = new Color(139, 198, 252);
    public Color to = new Color(0, 255, 0);
    public float switchDuration = 1f;
  
    void Update()
    {
        img.color = Color.Lerp(from, to, Mathf.PingPong(Time.time / switchDuration, 1));
    }
}

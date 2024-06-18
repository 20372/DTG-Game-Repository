using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    public Material mat;
    public Color[] colors;
    private int currentColorIndex = 0;
    private int targetColorIndex = 1;
    private float targetPoint;
    public float time;
    void Update()
    {
        
    }

    void Transition()
    {
        targetPoint += Time.deltaTime/time;
        mat.color = Color.Lerp(colors[currentColorIndex], colors[targetColorIndex], targetPoint);
        if (targetPoint >= 1f)
        {
            targetPoint = 0f;
            currentColorIndex = targetColorIndex;
            targetColorIndex++;
            if (targetColorIndex == colors.Length)
            {
                targetColorIndex = 0;
            }
        }
    }
}

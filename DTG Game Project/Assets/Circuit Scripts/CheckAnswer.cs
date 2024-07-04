using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer : MonoBehaviour
{

    public Inventory_Click inventory_Click;
    public DifferentLevels differentLevels;

    public bool isPowerCorrect;
    public bool topLeftCorrect;
    public bool topRightCorrect;
    public bool areBothSame;
    public void CheckPressed()
    {
        
        if (isPowerCorrect && topLeftCorrect && topRightCorrect && areBothSame==false)
        {
            Debug.Log("CORRECT");
            differentLevels.NextLevel();
        }
    }
}

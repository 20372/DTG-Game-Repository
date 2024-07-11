using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckAnswer : MonoBehaviour
{

    public CircuitPlaySounds circuitPlaySounds;

    public Inventory_Click inventory_Click;
    public DifferentLevels differentLevels;
    public TextMeshProUGUI attempts;
    public CongratsFade congratsFade;

    public bool isPowerCorrect;
    public bool topLeftCorrect;
    public bool topRightCorrect;
    public bool areBothSame;

    private int attemptsLeft;

    private void Start()
    {
        attemptsLeft = 3;
        areBothSame = true;
    }
    public void CheckPressed()
    {
        
        if (isPowerCorrect && topLeftCorrect && topRightCorrect && areBothSame==false)
        {
            circuitPlaySounds.correct();
            differentLevels.NextLevel();
        }
        else
        {
            attemptsLeft = attemptsLeft - 1;
            attempts.text = "Attempts Remaining - " + attemptsLeft;
            circuitPlaySounds.incorrect();
            if (attemptsLeft <= 0)
            {
                congratsFade.FadeInLose();
            }
        }
    }
}

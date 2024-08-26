using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CircuitManager : MonoBehaviour
{
    public CongratsFade congratsFade; //References another sctipt
    public CircuitPlaySounds circuitPlaySounds;

    private bool isItemOnHand;
    private bool isPowerCorrect;
    private bool topLeftCorrect;
    private bool topRightCorrect;   //Bools used to check if answer is correct 
    private bool areBothSame;
    private bool isResistorOrOutput;
    private bool canClick;

    private int currentImageInt;
    private int topLeftValue;
    private int topRightValue;
    private int outputOBJ;
    private int numberCheck;
    private int attemptsLeft;

    public List<Image> circuitImages;
    public List<Sprite> components;
    public List<int> everyOutput;
    public TextMeshProUGUI attempts;
    public TextMeshProUGUI objText;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None; //Makes the mouse visable
        Cursor.visible = true;
    }
    private void Start()
    {
        circuitImages[0].enabled = false;
        currentImageInt = 100;
        SetObjective(0);
        numberCheck = 0;  //Sets Variables to default vaule 
        attemptsLeft = 3;
        areBothSame = true;
        canClick = false;
    }
    private void LateUpdate()
    {
        if (isItemOnHand)
        {
            circuitImages[0].enabled = true; //Enables the sprite when player is "holding" a component
        }
        else
        {
            circuitImages[0].enabled = false;
        }
        if (topLeftValue == topRightValue) //if left and right are same circuit is wrong 
        {
            areBothSame = true;
        }
        else
        {
            areBothSame = false;
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);  //Waits 0.5 seconds
    }
    public void ResetCircuit()
    {
        circuitImages[1].sprite = components[5];
        circuitImages[2].sprite = components[5]; //Resets the circuit sprites to question marks
        circuitImages[3].sprite = components[5];
    }
    public void SetObjective(int objective)
    {
        outputOBJ = objective; //updates the correct output (e.g led speaker etc)
    }
    public void InventoryButtonClicked(int slotIndex) //If you click on a component sets "hand sprite" to enable ad updates it to be same as the one your clicked on
    {
        isItemOnHand = true;
        canClick = true;
        circuitPlaySounds.select();
        circuitImages[0].sprite = components[slotIndex];
        currentImageInt = slotIndex;
    }

    public void CircuitPosition(int CircuitIndex) //Checks if circuit is correct by using bools saved above 
    {
        if (canClick == true)
        {
            isItemOnHand = false;
            circuitPlaySounds.place();
            isResistorOrOutput = currentImageInt == 2 || currentImageInt == outputOBJ;

            switch (CircuitIndex)
            {
                case 0: // top left 
                    circuitImages[1].sprite = components[currentImageInt];
                    topLeftCorrect = isResistorOrOutput;
                    if (currentImageInt == 2)
                    {
                        topLeftValue = 2;
                    }
                    else
                    {
                        topLeftValue = 15;
                    }
                    if (currentImageInt != outputOBJ && currentImageInt != 2)
                    {
                        topLeftCorrect = false;
                        topLeftValue = 5;
                    }
                    break;

                case 1: // top right
                    circuitImages[2].sprite = components[currentImageInt];
                    topRightCorrect = isResistorOrOutput;
                    if (currentImageInt == 2)
                    {
                        topRightValue = 2;
                    }
                    else
                    {
                        topRightValue = 15;
                    }
                    if (currentImageInt != outputOBJ && currentImageInt != 2)
                    {
                        topRightCorrect = false;
                        topLeftValue = 0;
                    }
                    break;

                case 2: // bottom middle
                    circuitImages[3].sprite = components[currentImageInt];
                    isPowerCorrect = currentImageInt == 1;
                    break;
            }
        }
        canClick = false;
       
    }
    
    public void NextLevel()
    {
        numberCheck = numberCheck + 1; //Loads next objective e.g led to speaker etc
        isPowerCorrect = false;
        topLeftCorrect = false;
        topRightCorrect = false;

        switch (numberCheck)
        {
            case 0:
                SetObjective(0);
                objText.text = "TURN LED ON";
                ResetCircuit();
                break;
            case 1:
                SetObjective(3);
                objText.text = "TURN SPEAKER ON";
                ResetCircuit();
                break;
            case 2:
                SetObjective(4);
                objText.text = "TURN MOTOR ON";
                ResetCircuit();
                break;
            case 3:
                StartCoroutine(Wait());
                congratsFade.FadeInWin();
                break;
        }
    }
    public void CheckPressed()
    {
        if (isPowerCorrect && topLeftCorrect && topRightCorrect && areBothSame == false) //This function runs when user clicks the green button 
        {
            circuitPlaySounds.correct();
            NextLevel();
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

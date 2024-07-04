using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Inventory_Click : MonoBehaviour
{
    private bool isItemOnHand;
    public FollowMousePosition followMousePosition;
    public Image itemInHand;
    public Image circuit_topLeft;
    public Image circuit_topRight;
    public Image circuit_bottom_middle;
    public Sprite question;
  
    public List<Sprite> components; //List of every component player can use 

    public CheckAnswer checkAnswer; //ref other script

    private int currentImageInt;
    private int topLeftValue;
    private int topRightValue;


    private int outputOBJ;

    public void ResetCircuit()
    {
        circuit_topLeft.sprite = question;
        circuit_topRight.sprite = question;
        circuit_bottom_middle.sprite = question;
    }
    public void Start()
    {
        itemInHand.enabled = false; 
        currentImageInt = 100;
    }

    public void LateUpdate()
    {
       if (topLeftValue == topRightValue) //if left and right are same circuit is wrong 
        {
            checkAnswer.areBothSame = true;
        }
       else             //updates bool
        {
            checkAnswer.areBothSame = false;
        }
    }

    public void SetObjective(int objective)
    {
        outputOBJ = objective; //updates the correct output (e.g led speaker etc)
    }
    public void InventoryButtonClicked(int slotIndex) //If you click on a component sets "hand sprite" to enable ad updates it to be same as the one your clicked on
    {
        Debug.Log("You pressed slot " + (slotIndex + 1));
        isItemOnHand = true;
        itemInHand.sprite = components[slotIndex];
        currentImageInt = slotIndex;
    }

    public void CircuitPosition(int CircuitIndex)
    {
        Debug.Log("Changed Circuit Position to ");
        isItemOnHand = false;
        if (CircuitIndex == 0) //top left button
        {
            circuit_topLeft.sprite = components[currentImageInt]; //updates the circuit sprite 
            if (currentImageInt == 2 || currentImageInt == outputOBJ) //if image is a resistor or correct output = true 
            {
                checkAnswer.topLeftCorrect = true;  //sets the bool = true 
                if (currentImageInt == 2)
                {
                    topLeftValue = 2; // asigns top left value based on what image was selected. Used for checking if left/right are the same 
                }
                else
                {
                    topLeftValue = 15;
                }
                   
            }
            if (currentImageInt != outputOBJ && currentImageInt != 2) //if the selected component isnt a resistor or rght output sets the bool = false 
            {
                checkAnswer.topLeftCorrect = false; // bool = false
                topLeftValue = 5; //random topleft value to prevent error 
            }
           
        }
        if (CircuitIndex == 1)// top right button 
        {
            circuit_topRight.sprite = components[currentImageInt]; //updates the circuit sprite 
            if (currentImageInt == 2 || currentImageInt == outputOBJ)  //if image is a resistor or correct output = true 
            {
                checkAnswer.topRightCorrect = true; //Same as above 
                if (currentImageInt == 2)
                {
                    topLeftValue = 2;
                }
                else
                {
                    topLeftValue = 15;
                }

            }
            if (currentImageInt != outputOBJ && currentImageInt != 2)
            {
                checkAnswer.topRightCorrect = false; //Same as above 
                topLeftValue = 0;
            }
           
        }
        if (CircuitIndex == 2) //bottom middle button
        {
            circuit_bottom_middle.sprite = components[currentImageInt]; //updates image 
            if(currentImageInt == 1) //battery image is number 1 
            {
                checkAnswer.isPowerCorrect = true; //sets true else sets false 
            }
            else
            {
                checkAnswer.isPowerCorrect = false;
            }
        }

    }

    private void Update()
    {
        if(isItemOnHand)
        {
            itemInHand.enabled = true; //Enables the sprite when player is "holding" a component
        }
        else
        {
            itemInHand.enabled = false;
        }
    }


}

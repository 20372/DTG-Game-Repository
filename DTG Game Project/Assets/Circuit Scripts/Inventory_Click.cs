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
   
    public List<Sprite> components;



    private int currentImageInt;

    public void Start()
    {
        itemInHand.enabled = false;
        currentImageInt = 100;
    }
    public void InventoryButtonClicked(int slotIndex)
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
        if (CircuitIndex == 0)
        {
            circuit_topLeft.sprite = components[currentImageInt];
        }
        if (CircuitIndex == 1)
        {
            circuit_topRight.sprite = components[currentImageInt];
        }
        if (CircuitIndex == 2)
        {
            circuit_bottom_middle.sprite = components[currentImageInt];
        }

    }

    private void Update()
    {
        if(isItemOnHand)
        {
            itemInHand.enabled = true;
        }
        else
        {
            itemInHand.enabled = false;
        }
    }


}

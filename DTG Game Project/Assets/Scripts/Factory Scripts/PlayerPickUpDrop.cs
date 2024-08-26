using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    [SerializeField] private Transform ObjectGrabPointTransform;
    public bool isHolding; //Variables 
    private ObjectGrab objectGrabable;
    public void Awake()
    {
        isHolding = false; //Sets to default state
    }
    public void ChangeIsHoldingBoolValue(int value)
    {
        if(value == 0)
        {
            isHolding = false;
        }
        else
        {
            isHolding = true;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isHolding == false)
        {
            float pickUpDistance = 2f; //This code runs if user pressed E and isnt holding anything, then It will try to pick somehting up 
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit hit, pickUpDistance, pickUpLayerMask)) {
                if (hit.transform.TryGetComponent(out ObjectGrab objectGrabable))
                {
                    isHolding = true;
                    this.objectGrabable = objectGrabable; //If ray hits a gameojevt with ObjectGrab script it called the Grab function and picks it up
                    objectGrabable.Grab(ObjectGrabPointTransform);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E) && isHolding == true) //If user presses E and its allready holding somehting it called the drop function 
            {
                isHolding = false;
                objectGrabable.Drop();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    [SerializeField] private Transform ObjectGrabPointTransform;
    public bool isHolding;
    private ObjectGrab objectGrabable;
    public void Awake()
    {
        isHolding = false;
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
            Debug.Log("Pressed E and is holding is false");
            float pickUpDistance = 2f;
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit hit, pickUpDistance, pickUpLayerMask)) {
                if (hit.transform.TryGetComponent(out ObjectGrab objectGrabable))
                {
                    isHolding = true;
                    this.objectGrabable = objectGrabable;
                    objectGrabable.Grab(ObjectGrabPointTransform);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E) && isHolding == true)
            {
                Debug.Log("Pressed E and is holding is true");
                isHolding = false;
                objectGrabable.Drop();
                Debug.Log("DROP");
            }
        }
    }
}

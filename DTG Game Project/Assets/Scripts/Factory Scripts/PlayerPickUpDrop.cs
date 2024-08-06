using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{

    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    [SerializeField] private Transform ObjectGrabPointTransform;

    private ObjectGrab objectGrabable;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objectGrabable == null) //not carrying 
            {
                float pickUpDistance = 2f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit hit, pickUpDistance, pickUpLayerMask))
                {
                    if (hit.transform.TryGetComponent(out ObjectGrab objectGrabable))
                    {
                        objectGrabable.Grab(ObjectGrabPointTransform);
                    }
                }
            }
            else // is carrying 
            {
                objectGrabable.Drop();
                objectGrabable = null;
            }
        }
    }
}

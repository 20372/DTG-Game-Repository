using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScripts : MonoBehaviour
{
    //global variables used in fixedupdate to set new camera position
    private Vector3 offset = new Vector3(0f, 0f, -10f); //camera offset
    private float smoothTime = 0.25f; // time delay 
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target; //player

    private void FixedUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime); //sets the camera position to the players position with an ofset and small delay so it looks better
    }
}

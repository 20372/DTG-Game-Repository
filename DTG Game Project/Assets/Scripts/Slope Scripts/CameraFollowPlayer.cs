using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset; // Offset from the player

    void Start()
    {
        
    }

    void LateUpdate()
    {
     
        transform.position = player.position + offset; //Updates Camera to follow player with a offset 
   
    }
}

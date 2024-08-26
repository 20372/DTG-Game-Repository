using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrab : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;
    [SerializeField] private PlayerPickUpDrop playerPickUpDrop;
    public void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
        GameObject player = GameObject.Find("Player"); //Setting Componet References 
        playerPickUpDrop = player.GetComponent<PlayerPickUpDrop>();
    }
    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform; //Grab Function sets object grabbed position equal to grabpoint position (is in front of player)
        objectRigidbody.useGravity = false;
    }
    public void Drop()
    {
        objectGrabPointTransform = null; //Drops item when called 
        objectRigidbody.useGravity = true;
    }
    private void FixedUpdate()
    {
        if (objectGrabPointTransform != null)
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime * lerpSpeed);  //Slowly moves object toward objectGrabPointTransform 
            objectRigidbody.MovePosition(newPosition);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Ground"))
        {
            playerPickUpDrop.ChangeIsHoldingBoolValue(0); //If objects Hits wall or ground auto drops item 
            Drop();
        }
    }
}

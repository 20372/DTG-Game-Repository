using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{

    public Rigidbody2D rb; //RididBody of the playerpoint gameobject (this gameobject is used to spanw the bullets at and rotations based on where the mouse is on the screen.
    public Camera cam; //gets the cameras 
    Vector2 mousePos; //vector2 used to store the mouse position
    public GameObject player; //player gameobject 
    private Rigidbody2D playerRb; //player ridigbody

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); //gets mouse pos 
        rb.transform.position = player.transform.position; //moves empty with the player at all times
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f; //Rotates an empty object to face player used for throwing the sword 
        rb.rotation = angle;


    }
}

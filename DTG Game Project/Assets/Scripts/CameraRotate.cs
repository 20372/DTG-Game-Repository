using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{ //sens variable
    public float sensX;
    public float sensY;
    public GameObject player;
    public Vector3 offset;
    public Transform orientation;
    //rotation variable 
    float rotX;
    float rotY;
    void Start()
    {
        transform.position = player.transform.position + offset;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        //Users mouse input   
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        rotY += mouseX;
        rotX -= mouseY;
        rotX = Mathf.Clamp(rotX, -90f, 90f);
        //rotate camera 
        transform.rotation = Quaternion.Euler(rotX, rotY, 0);
        orientation.rotation = Quaternion.Euler(0, rotY, 0);
    }
}

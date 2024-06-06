using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody rb;
    Vector3 lookPos;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        lookPos.x = Input.GetAxisRaw("Horizontal") * speed;
        lookPos.y = Input.GetAxisRaw("Vertical") * speed;

        rb.velocity = new Vector3(lookPos.x, 0, lookPos.y);
    }
    void FixedUpdate()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoForward : MonoBehaviour
{
    public float forwardForce = 10.0f; // The amount of force to apply
    public float jumpForce = 1000;
    private Rigidbody rb;
    private bool isGrounded;
    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(Vector3.forward * forwardForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            
            rb.AddForce(Vector3.left * forwardForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * forwardForce * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space) & isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collides with the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Check if the player exits collision with the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

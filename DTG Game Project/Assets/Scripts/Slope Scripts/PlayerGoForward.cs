using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoForward : MonoBehaviour
{
    [SerializeField] private SlopeSound slopeSound;
    public float forwardForce = 10.0f; // The amount of force to apply
    public float jumpForce = 1000;
    private Rigidbody rb;
    private bool isGrounded;
    public CanvasGroup PressToStart;
    private float increase;
    private float waitTime;
    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();
        forwardForce = 0;
        jumpForce = 0;
        increase = 0.001f;
        waitTime = 0.001f;
    }

    private void Awake()
    {
        StartCoroutine(Wait());
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
            slopeSound.playJump();
            isGrounded = false;
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2.5f);
        forwardForce = 1000;
        jumpForce = 12;
        StartCoroutine(FadePressToStart());
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

    private IEnumerator FadePressToStart()
    {
        while (true)
        {
            PressToStart.alpha = PressToStart.alpha - increase;
            yield return new WaitForSeconds(waitTime);

            if (PressToStart.alpha == 0)
            {
                break;
            }
        }
    }
}

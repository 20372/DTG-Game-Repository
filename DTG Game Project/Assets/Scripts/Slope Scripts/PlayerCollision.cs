using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public SceneInfo1 sceneInfo1;
    private SlopeHealth slopeHealth;
    public Transform playerPos;
    private Vector3 startPos;
    private Rigidbody rb;
   
    private void Start()
    {
        slopeHealth = FindObjectOfType<SlopeHealth>();
        startPos = playerPos.transform.position;
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        ProcessCollision(collision.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        ProcessCollision(other.gameObject);
    }

    public void ProcessCollision (GameObject coll)
    {
        if (coll.gameObject.CompareTag("Void"))
        {
            playerPos.transform.position = startPos;
            rb.velocity = Vector3.zero;
            slopeHealth.TakeDamage();
        }
        if (coll.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Factory");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.up, ForceMode2D.Impulse); //Move the sword forward
    }
    private void FixedUpdate()
    {
        Physics2D.IgnoreLayerCollision(7, 8); //ignore collision with the player
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Sword") || collision.CompareTag("Enemy")) //Destory the object if it collides with anything expect player, sword, enemy 
        {
            return;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}

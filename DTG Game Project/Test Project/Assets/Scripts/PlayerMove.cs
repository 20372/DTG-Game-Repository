using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private float speed = 10;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 MousePos;
    public Transform spawnPos; //variables used for movement 
    public int Lives = 3;
    public TextMeshProUGUI livestext;
   
    private void Update() //GETS PLAYERS INPUT 
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

       
    }
    private void FixedUpdate() //MOVES THE PLAYER BASED ON THEIR INPUT 
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime); //updates its position
       
    }

   


    public void OnTriggerEnter2D(Collider2D collision) //Checks if the player has taken damage from enemy
    {
        if (collision.CompareTag("Enemy"))
        {
            transform.position = spawnPos.position;
            Lives = Lives - 1;
            livestext.text = "Player Lives - " + Lives;
            if (Lives == 0)
            {
                PlayerDead();

            }
        }
        
    }

    public void PlayerDead()
    {
        // Calls game over screen
        // Game OVER !!! 
        SceneManager.LoadScene("GameOver");
    }
   

}

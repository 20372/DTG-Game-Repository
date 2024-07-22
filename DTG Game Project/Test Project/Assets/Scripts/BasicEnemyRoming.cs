using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyRoming : MonoBehaviour
{
    public bool IsEnemyhere;
    private Transform target;
    private Vector2 moveDir;
    [SerializeField] public float enemyHealth = 5f; //enemy health variable 
    public GameObject Point1; //first point the enemy moves to
    public GameObject Point2; //second point the enemy moves to
    public float speed = 3f; //float for speed
    private Rigidbody2D rb;
    private Transform currentPoint;


    // Start is called before the first frame update
    private void Start()
    {
        
        IsEnemyhere = false;
        rb = GetComponent<Rigidbody2D>();
        currentPoint = Point2.transform; //sets currentPoint == point 2 at the start
        target = GameObject.Find("Player").transform;
    }

  
    private void Update()
    {

        if (IsEnemyhere == false)
        {
            if (currentPoint == Point2.transform) //if player has reached the point makes it go the other direction
            {
                rb.velocity = new Vector2(speed, 0);
            }
            else
            {
                rb.velocity = new Vector2(-speed, 0); //makes the enemy move to point2 
            }

        }
        else
        {
            if (IsEnemyhere == true) //If true the player so near enemy so will set dir and velocity to attavk the player
            {
                Vector3 direction = (target.position - transform.position).normalized;
                moveDir = direction;
                rb.velocity = new Vector2(moveDir.x, moveDir.y) * speed;
                
            }
           
         
        }
       
    }
    private void FixedUpdate()
    {
        if (IsEnemyhere == true)
        {
            
        }
        if (IsEnemyhere == false) //If player isnt close sets enemy to go back to its normal pathing 
        {
            if (transform.position.x >= Point2.transform.position.x) //when the enemy position is greater then point2 sets currewnt point = to point1
            {
                currentPoint = Point1.transform;

            }
            if (transform.position.x <= Point1.transform.position.x) //same as above but does opposite 
            {
                currentPoint = Point2.transform;
            }

        }
       
    }


    public void IsHereTrue()
    {
        IsEnemyhere = true; //Function called to change bool
    }

    public void IsHereFalse()
    {
        IsEnemyhere = false;
    }

    
    public void enemyTakeDamage() //Is used to the enemies have Health and can take damage 
    {
        enemyHealth = enemyHealth - 1f; //removes 1 hp when you shoot it 
        if (enemyHealth <= 0f)
        {
            Destroy(gameObject); //deletes enemy when runs out of health
        }

    }
}

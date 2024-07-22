using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCode : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(MoveTrain());
    }
    IEnumerator MoveTrain() //Uses to move the train up and down the trackes while having a small delay at each end of the platform
    {
       while (true)
        {
            rb.velocity = new Vector2(0, speed); //move up
            yield return new WaitForSeconds(25); //waits intill at top
            rb.velocity = new Vector2(0, -speed); //move down
            yield return new WaitForSeconds(25); // waits till at botttom 
            //repeat

        }
      
    }
}

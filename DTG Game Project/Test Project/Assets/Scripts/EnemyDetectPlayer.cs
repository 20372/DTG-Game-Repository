using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDetectPlayer : MonoBehaviour
{
    public BasicEnemyRoming basicEnemyRoming;
    public void OnTriggerEnter2D(Collider2D collision) //checks for collisions in unity
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player Nearby ATTACKHIM");
            basicEnemyRoming.IsHereTrue(); //Sets True of bool so enemy can attack him
        }
        else
        {
            
            //set postion back to starting position
            basicEnemyRoming.IsHereFalse(); //sets false when enemy goes away

        }
    }
}

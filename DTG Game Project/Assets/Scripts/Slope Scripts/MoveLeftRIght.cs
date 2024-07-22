using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRIght : MonoBehaviour
{
    public float speed = 5.0f; // Speed of the cube's movement
    public float distance = 10.0f; // Distance to move before changing direction

    private Vector3 startPosition;
    private bool movingRight = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= startPosition.x + distance)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= startPosition.x - distance)
            {
                movingRight = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;
    Vector2 lookPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lookPos.x = Input.GetAxis("Horizontal");
        lookPos.y = Input.GetAxis("Vertical");

       
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("pRESSED W");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}

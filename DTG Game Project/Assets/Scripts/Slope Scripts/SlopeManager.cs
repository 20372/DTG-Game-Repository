using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeManager : MonoBehaviour
{
    [SerializeField] private SlopeSound slopeSound;
    public float strength;
    public GameObject player;
    void Start()
    {
        Physics.gravity = new Vector3(0, -strength, 0); //Makes gravity stronger in slope game only
    }

    private void OnDisable()
    {
        Physics.gravity = new Vector3(0, -9.81f, 0); //Resets Gravity to normal value 
    }

    public void SlowPlayer(Rigidbody rb)
    {
        slopeSound.playSlowDown();
        rb.velocity = rb.velocity * 0.3f;
    }
    public void SpeedUpPlayer(Rigidbody rb) //Adjusts player speed when going through either a speed or slow gate 
    {
        slopeSound.playSpeedReset();
        rb.velocity = rb.velocity * 1.3f;
    }
}

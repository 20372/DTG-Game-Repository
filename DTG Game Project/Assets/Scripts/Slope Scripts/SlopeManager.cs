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
        Physics.gravity = new Vector3(0, -strength, 0);
    }

    private void OnDisable()
    {
        Physics.gravity = new Vector3(0, -9.81f, 0);
    }

    public void SlowPlayer(Rigidbody rb)
    {
        slopeSound.playSlowDown();
        rb.velocity = rb.velocity * 0.3f;
    }
    public void SpeedUpPlayer(Rigidbody rb)
    {
        slopeSound.playSpeedReset();
        rb.velocity = rb.velocity * 1.3f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimations : MonoBehaviour
{

    [SerializeField] private Animation open;
    // Start is called before the first frame update
    void Start()
    {
        open.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

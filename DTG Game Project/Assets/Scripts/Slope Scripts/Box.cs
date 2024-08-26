using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public BoxCollider boxCollider;
    public float waitTime;
    public Material SOLID;
    public Material WALKABLE;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        StartCoroutine(WaitTime()); //Starts Function when scenes opens 
    }

    private void Update()
    {
    }

    IEnumerator WaitTime()
    {
        while(true) //Runs forever and changes box from solid to transparent 
        {
            boxCollider.isTrigger = false;
            rend.material = SOLID;
            yield return new WaitForSeconds(waitTime);
            boxCollider.isTrigger = true;
            rend.material = WALKABLE;
            yield return new WaitForSeconds(waitTime);
        }
    }

  
}

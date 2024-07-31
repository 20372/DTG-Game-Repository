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
        StartCoroutine(WaitTime());
    }

    private void Update()
    {
    }

    IEnumerator WaitTime()
    {
        while(true)
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

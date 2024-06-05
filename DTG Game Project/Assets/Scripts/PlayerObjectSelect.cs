using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectSelect : MonoBehaviour
{
   RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RayFire();
        }
    }

    void RayFire()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(cameraRay, out hit))
        {
            Debug.Log(hit.collider.gameObject.name + "was hit");
           
        }
    }
}

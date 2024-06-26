using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerObjectSelect : MonoBehaviour
{
    RaycastHit hit;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireRay();
        }
    }

    void FireRay()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(cameraRay, out hit))
        {
            Debug.Log(hit.collider.gameObject.name + " was hit");
            if(hit.collider.gameObject.CompareTag("Table"))
            {
                SceneManager.LoadScene("Computer", LoadSceneMode.Additive);
            }
           
        }
    }
}

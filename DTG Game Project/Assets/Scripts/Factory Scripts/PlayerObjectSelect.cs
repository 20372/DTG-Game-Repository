using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerObjectSelect : MonoBehaviour
{
    RaycastHit hit;
    public GameSetup gameSetup;
    public HealthManager healthManager; 
    public Camera mainCamera;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireRay();
        }
    }

    void FireRay()
    {
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(cameraRay, out hit))
        {
            if(hit.collider.gameObject.CompareTag("Slope"))
            {
                gameSetup.SavePlayerInfo();
                SceneManager.LoadScene("Slope");
            }
            if(hit.collider.gameObject.CompareTag("Circuit"))
            {
                gameSetup.SavePlayerInfo();
                SceneManager.LoadScene("Circuit");
            }
           
        }
    }
}

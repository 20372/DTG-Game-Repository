using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerObjectSelect : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] private GameSetup gameSetup;
    [SerializeField] private HealthManager healthManager;
    [SerializeField] Camera mainCamera;
    [SerializeField] private LayerMask computer;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RayToCheckIfComputerIsClicked(); //When Click Shots RayOut in straight line 
        }
    }
    void RayToCheckIfComputerIsClicked() //If Ray hits a computer loads either slope or circuit scene
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

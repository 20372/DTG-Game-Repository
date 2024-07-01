using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerObjectSelect : MonoBehaviour
{
    RaycastHit hit;
    public SceneInfo1 sceneInfo1;
    public HealthManager healthManager;
    public GameObject player;
    public GameObject cameraParent;
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
            if(hit.collider.gameObject.CompareTag("Computer"))
            {
                sceneInfo1.current_playerHealth = healthManager.healthAmount;
                sceneInfo1.current_playerPos = player.transform.position;
                sceneInfo1.current_PlayerCameraPos = cameraParent.transform.position;
                Debug.Log(healthManager.healthAmount);
                SceneManager.LoadScene("Computer");
            }
           
        }
    }
}

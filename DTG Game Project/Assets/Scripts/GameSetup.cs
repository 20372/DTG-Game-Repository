using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    [SerializeField]
    public SceneInfo1 sceneInfo1;
    public HealthManager healthManager;
    public PlayerMovement playerMovement;
    public GameObject player;
    public GameObject cameraParent;
    // Start is called before the first frame update

    private void Awake()
    {
        healthManager.healthAmount = sceneInfo1.current_playerHealth;
        Debug.Log(healthManager.healthAmount + "FR");
        healthManager.ResetHealthAmount(healthManager.healthAmount);
        playerMovement.moveSpeed = sceneInfo1.curret_playerSpeed;
        player.transform.position = sceneInfo1.current_playerPos;
        cameraParent.transform.position = sceneInfo1.current_PlayerCameraPos;
        Debug.Log("HELLO");
    }
   

}

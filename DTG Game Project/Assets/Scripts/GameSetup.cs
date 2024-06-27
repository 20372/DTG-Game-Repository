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
    // Start is called before the first frame update
    void Start()
    {
        healthManager.healthAmount = sceneInfo1.current_playerHealth;
        playerMovement.moveSpeed = sceneInfo1.curret_playerSpeed;
        player.transform.position = sceneInfo1.current_playerPos;

    }

}

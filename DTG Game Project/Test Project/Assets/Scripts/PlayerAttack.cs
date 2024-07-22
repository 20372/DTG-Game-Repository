using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject sword;
    public float speed = 5f;
    public Transform spawnPos;

    
    private void Update()
    {
        if (Input .GetKeyUp(KeyCode.Space))
        {
            Instantiate(sword, spawnPos.position, spawnPos.rotation); //Spawns sword if player press space bar

        }

    }


}

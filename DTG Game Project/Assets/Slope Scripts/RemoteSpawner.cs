using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteSpawner : MonoBehaviour
{
    public GameObject Prefab;
    public int numberOfRemotes;
    public Vector3 spawnArea = new Vector3(100, 50, 100); // Size of the spawn area

    void Start()
    {
        SpawnRemotes(); 
    }

    void SpawnRemotes() 
    {
        for (int i = 0; i < numberOfRemotes; i++)
        {
            Vector3 randomPosition = FindEmptyPosition(); // Corrected assignment and function call

            Instantiate(Prefab, randomPosition, Quaternion.identity); // Spawn the prefab at the found position
        }
    }

    Vector3 FindEmptyPosition() // Moved FindEmptyPosition outside of SpawnRemotes
    {
        Vector3 randomPosition = Vector3.zero;
        bool positionFound = false;
        int maxAttempts = 10; // Maximum attempts to find an empty position

        for (int attempt = 0; attempt < maxAttempts; attempt++)
        {
            randomPosition = new Vector3(
                Random.Range(-spawnArea.x / 2, spawnArea.x / 2),
                Random.Range(20, spawnArea.y),
                Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
            );

            Collider[] colliders = Physics.OverlapSphere(randomPosition, 1.0f); // Adjust radius as needed

            if (colliders.Length == 0)
            {
                positionFound = true;
                break;
            }
        }

        if (!positionFound)
        {
            Debug.Log("Could not find an empty position after multiple attempts.");
        }

        return randomPosition;
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Tile : MonoBehaviour
{

    Ground_Spawner groundSpawner;
    public GameObject obstaclePrefab;


    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<Ground_Spawner>();
        SpawnObstacle();
    }

    void OnTriggerExit (Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject,1);
    }

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(2,5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }    
}
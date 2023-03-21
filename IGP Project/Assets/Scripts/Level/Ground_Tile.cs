using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Tile : MonoBehaviour
{

    Ground_Spawner groundSpawner;
    public GameObject obstaclePrefab;
    public GameObject collectables;

    

    void Start()
    {   // What to spawn on the platforms
        groundSpawner = GameObject.FindObjectOfType<Ground_Spawner>();
        SpawnObstacle();
        SpawnFish();
    }

    void OnTriggerExit (Collider other)
    {    // Remove platform behind player
        groundSpawner.SpawnTile();
        Destroy(gameObject,1);
    }

    void SpawnObstacle()
    {    // Randomly chose which side of the platform to spawn at,left, right or middle
        int obstacleSpawnIndex = Random.Range(2,5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }    

    public void SpawnFish()
    {   // Amount of fish on each platform
        int fishToSpawn = 10;
        for (int i = 0; i < fishToSpawn; i++)
        { // Spawn collectable Prefab
          GameObject temp = Instantiate(collectables);
          temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }


    Vector3 GetRandomPointInCollider (Collider collider)
    {
        Vector3 point = new Vector3(
        Random.Range(collider.bounds.min.x, collider.bounds.max.x),
        Random.Range(collider.bounds.min.y, collider.bounds.max.y),
        Random.Range(collider.bounds.min.z, collider.bounds.max.z)
        );

        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }
}
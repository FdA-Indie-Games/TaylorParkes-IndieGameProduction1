using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Spawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {    // Spawn next platform at next spawn point
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    void Start()
    {   // Spawn 8 platforms on start
        for (int i = 0; i < 8; i++)
        SpawnTile();
    }
}

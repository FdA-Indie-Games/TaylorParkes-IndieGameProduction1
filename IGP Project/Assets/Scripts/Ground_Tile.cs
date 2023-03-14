using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Tile : MonoBehaviour
{

    Ground_Spawner groundSpawner;


    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<Ground_Spawner>();
        
    }

    void OnTriggerExit (Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject,2);
    }
}

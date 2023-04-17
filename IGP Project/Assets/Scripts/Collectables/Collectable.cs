using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{
    //Varibles
    public static event Action OnCollected;
    public static int total;

    void Awake() => total++;

    // When player colides with the object, destroy object 
    void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Player"))
      { 
        OnCollected?.Invoke();
        Destroy(gameObject);
      }
    }
}
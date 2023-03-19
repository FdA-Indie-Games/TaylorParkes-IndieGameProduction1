using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Player_Movement1 playerMovement;


    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<Player_Movement1>();
    }

     public void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.name == "Player") 
       playerMovement.Die();
    }
}
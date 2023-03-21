using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    Player_Movement1 playerMovement;


    private void Start()
    {   // Find the object with the Playermovement script
        playerMovement = GameObject.FindObjectOfType<Player_Movement1>();
    }

     public void OnCollisionEnter(Collision collision)
    {   // Find the player then if they collided with obstacle then load play again menu
       if (collision.gameObject.name == "Player") 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
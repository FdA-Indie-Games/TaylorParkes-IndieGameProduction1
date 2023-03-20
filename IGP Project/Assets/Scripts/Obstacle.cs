using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
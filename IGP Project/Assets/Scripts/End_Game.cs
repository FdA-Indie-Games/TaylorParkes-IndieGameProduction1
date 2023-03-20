using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Game : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)

    {
        if ( collision.gameObject.name == "enemy") 
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }   
    }
}

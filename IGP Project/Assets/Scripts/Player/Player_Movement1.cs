using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement1 : MonoBehaviour
{
    
    public float speed = 5;
    // Forward speed
    public float leftRightSpeed = 4;
    // Turning speed 
    void FixedUpdate()
    {
        //Forward Movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);

        // Right Movement
         if (Input.GetKey(KeyCode.D) ||  Input.GetKey(KeyCode.RightArrow))
         {
            if (this.gameObject.transform.position.y > Level_Borders.leftSide)
           {
               transform.Translate(Vector3.forward * Time.deltaTime * leftRightSpeed);
            }
         }

         // Left Movement
        if (Input.GetKey(KeyCode.A)  ||  Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.y < Level_Borders.rightSide)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * leftRightSpeed * -1);
            }
        }
    }

    private void Update()
    {   // Player dies after going below -5 (Falling from game)
        if (transform.position.y < -5)
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
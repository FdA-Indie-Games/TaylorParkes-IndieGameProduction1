using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement1 : MonoBehaviour
{
    
    public float speed = 5;
    public float leftRightSpeed = 4;

    
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);

        if (Input.GetKey(KeyCode.A) ||  Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.y > Level_Borders.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D)  ||  Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.y < Level_Borders.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }

    }
}
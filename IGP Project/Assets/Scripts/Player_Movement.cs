using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //Variables
    public Rigidbody Rigid;
    public float moveSpeed;

     // Player movement using rigidbody
    void Update()
    {
        Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * moveSpeed) + (transform.right * Input.GetAxis("Horizontal") * moveSpeed));
    }
}

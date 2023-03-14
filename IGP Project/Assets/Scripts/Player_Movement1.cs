using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement1 : MonoBehaviour
{
    
    public float speed = 5;
    
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
    }
}
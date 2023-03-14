using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Chase : MonoBehaviour
{
    public Transform Player;
    public int MoveSpeed = 4;

    void Update()
    {
        transform.LookAt(Player);

        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
    }
}

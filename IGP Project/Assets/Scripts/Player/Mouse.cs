using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private void Update()
    {     // Show cursor after pressing M
        if (Input.GetKeyDown(KeyCode.M))
        {
            Cursor.visible = true;
        }
         // Hide cursor after pressing N
        else if (Input.GetKeyDown(KeyCode.N))
        {
            Cursor.visible = false;
        }
    }
}

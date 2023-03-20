using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Cursor.visible = true;
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            Cursor.visible = false;
        }
    }
}

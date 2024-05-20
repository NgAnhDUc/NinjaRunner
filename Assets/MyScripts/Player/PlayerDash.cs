using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.Translate(Vector2.right * 5.0f);
        }
    }
}

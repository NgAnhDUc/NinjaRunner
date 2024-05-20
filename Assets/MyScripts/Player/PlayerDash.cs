using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public float dashDistance =3;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.Translate(Vector2.right * dashDistance);
        }
    }
}

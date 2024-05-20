using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed =5;
    public Rigidbody2D rig;
    public float jumpHeight = 5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed*Time.deltaTime);
        if (Input.GetAxis("Jump") > 0)
        {
            transform.Translate(Vector3.up * jumpHeight * Time.deltaTime);
        }
    }
}

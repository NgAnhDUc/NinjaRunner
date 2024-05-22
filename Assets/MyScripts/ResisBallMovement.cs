using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResisBallMovement : MonoBehaviour
{
    float rotateSpeed = 150.0f;

    void Update()
    {
        float angle = rotateSpeed * Time.deltaTime;
        transform.RotateAround(transform.parent.position, Vector3.forward, angle);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Skill")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class WhirWindMovement : MonoBehaviour
{
    public float speed = 10f;
    public float count = 0f;
    public bool isBlast = false;

    void Update()
    {
        count += Time.deltaTime;
        if (isBlast) return;

        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (count >= 2) BlastWind();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (isBlast) return;
        if (collision.gameObject.tag == "Player")
        {
            BlastWind();
        }
    }

    public void BlastWind()
    {
        transform.localScale *= 2;
        isBlast = true;
        Invoke("DestroyObject",1f);
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}

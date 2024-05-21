using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class WhirWindMovement : MonoBehaviour
{
    public float speed = 5f;
    public float count = 0f;
    public bool isTrigger = false;

    void Update()
    {
        if (count > 2 || isTrigger ) return;


        count += Time.deltaTime;
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (count >= 2) BlastWind();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            BlastWind();
            isTrigger = true;
        }
    }

    public void BlastWind()
    {
        transform.localScale *= 2;
        StartCoroutine(DestroyGameObjectWithDelay());
    }

    IEnumerator DestroyGameObjectWithDelay()
    {
        yield return new WaitForSeconds(1.0f);

        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovement : MonoBehaviour
{
    public float count = 0;
    public bool isBlast = false;
    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.AddForce(new Vector2(-1,2) * 300);
    }

    private void Update()
    {
        count += Time.deltaTime;
        if (isBlast) return;

        if (count >= 2) BlastBomb();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBlast) return;
        if (collision.gameObject.tag == "Player") BlastBomb();
    }

    public void BlastBomb()
    {
        transform.localScale *= 2;
        isBlast = true;
        Invoke("DestroyObject", 1f);
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}

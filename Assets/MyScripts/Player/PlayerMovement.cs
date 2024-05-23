using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviourPunCallbacks
{
    public float speed =5;
    public Rigidbody2D rig;
    public float jumpHeight = 5;
    public bool isFlip = false;
    public bool onGround;
    public bool isRun = true;
    public Animator playerAnim;

    private void Awake()
    {
        this.playerAnim = GetComponent<Animator>();

    }
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.gravityScale = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (!photonView.IsMine) return;
        if (!isRun)
        {
            SetAnimIdle();
            return;
        }
        SetAnimRun();
        transform.Translate(Vector3.right * speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!onGround) return;
            rig.gravityScale *= -1; //change gravity scale of rigibody

            Invoke("FlipPlayer", 0.2f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = false;
        }
    }

    public void FlipPlayer()
    {
        transform.Rotate(Vector3.right * -180f);
    }
    protected void SetAnimRun()
    {
        this.playerAnim.SetBool("isRun", true);
    }
    protected void SetAnimIdle()
    {
        this.playerAnim.SetBool("isRun", false);
    }
}

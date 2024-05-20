using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public GameObject dashEffectGO;
    public Animator dashAnim;
    private void Awake()
    {
        this.dashEffectGO = GameObject.Find("EffectDash");
        this.dashAnim = this.dashEffectGO.GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.Translate(Vector2.right * 5.0f);
            this.SetDashAnim();
        }
    }
    protected void SetDashAnim()
    {
        this.dashAnim.SetBool("isDash", true);
        Invoke("SetFinishDashAnim", 0.06f);
    }
    protected void SetFinishDashAnim()
    {
        this.dashAnim.SetBool("isDash", false);
    }

}

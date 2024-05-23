using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerDash : MonoBehaviourPunCallbacks
{
    public float dashDistance =3;
    public GameObject dashEffectGO;
    public Animator dashAnim;
    public float count = 0;
    public float reloadTime = 5;
    public Slider dashSlider;
    public GameObject fillProcess;

    private void Awake()
    {
        this.dashEffectGO = GameObject.Find("EffectDash");
        this.dashAnim = this.dashEffectGO.GetComponent<Animator>();
        this.dashSlider = GameObject.Find("DashSlider").GetComponent<Slider>();
        this.fillProcess = dashSlider.transform.GetChild(1).GetChild(0).gameObject;

        dashSlider.maxValue = reloadTime;
    }
    void Update()
    {
        if (!photonView.IsMine) return;
        count += Time.deltaTime;
        dashSlider.value = count;
        if (count < reloadTime)
        {
            fillProcess.GetComponent<Image>().color = Color.red;
            return;
        }
        count = reloadTime;
        fillProcess.GetComponent<Image>().color = Color.green;


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.Translate(Vector2.right * dashDistance);
            this.SetDashAnim();
            count = 0; 
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class NetWorkState : MonoBehaviourPunCallbacks
{
    public TMP_Text stateNetWork;
    private void Reset()
    {
        this.stateNetWork = GetComponent<TMP_Text>();
    }
    void Update()
    {
        stateNetWork.text = PhotonNetwork.NetworkClientState.ToString();
        Debug.Log(stateNetWork.text);
    }
}

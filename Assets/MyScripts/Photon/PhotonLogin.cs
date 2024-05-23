using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
 

public class PhotonLogin :MonoBehaviourPunCallbacks
{
    public TMP_InputField nickName;
    private void Reset()
    {
        GameObject nicknameGO = GameObject.Find("NickName_TMP_Input");
        this.nickName = nicknameGO.GetComponent<TMP_InputField>();
    }
    public void LoginPhoton()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.LocalPlayer.NickName = nickName.text;
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
}

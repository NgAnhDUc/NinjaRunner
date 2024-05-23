using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class PlayerInRoomPhoton : MonoBehaviourPunCallbacks
{
    public Player[] players;
    public TMP_Text listPlayer;
    public string listPlayerStr="";
    private void Reset()
    {
        this.listPlayer = GetComponent<TMP_Text>();
    }
    public void GetPlayerList()
    {
        string listPlayerStr = "";
        this.players = PhotonNetwork.PlayerList;
        foreach (Player player in players)
        {
            listPlayerStr ="("+listPlayerStr + player.NickName +")";
        }
        listPlayer.text = listPlayerStr;
    }
    public override void OnCreatedRoom()
    {
        this.GetPlayerList();
    }
    public override void OnJoinedRoom()
    {
        this.GetPlayerList();
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        this.GetPlayerList();
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        this.GetPlayerList();
    }
}

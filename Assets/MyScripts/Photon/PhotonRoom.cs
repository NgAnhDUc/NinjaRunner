using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class PhotonRoom : MonoBehaviourPunCallbacks
{
    public void HostRoomPhoton()
    {
        if (!PhotonNetwork.IsConnected) return;
        RoomOptions roomOptions = new RoomOptions() { MaxPlayers = 4 };
        string idRoom = "1000";
        PhotonNetwork.CreateRoom(idRoom,roomOptions,null);
    }

    public void JoinRoomPhoton()
    {
        if (!PhotonNetwork.IsConnected) return;
        PhotonNetwork.JoinRoom("1000");
    }
    
}

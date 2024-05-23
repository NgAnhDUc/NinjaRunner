using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PhotonPlayGame : MonoBehaviourPunCallbacks
{
    public void PlayGamePhoton()
    {
        PhotonNetwork.LoadLevel("SampleScene");
    }
}

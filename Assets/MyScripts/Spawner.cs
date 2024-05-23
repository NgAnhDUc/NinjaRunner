using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Photon.Pun;

public class Spawner : MonoBehaviourPunCallbacks
{
    public GameObject prefab;
    public Transform parent;
    public int quatity =1 ;
    public Vector3 posisionSpawn;
    public GameObject clone;
    
    public void SpawnPrefabs(GameObject prefab, Transform parent, int quantity, Vector3 posisionSpawn,string prefabName)
    {
        if (PhotonNetwork.IsConnected)
        {
            for (int i = 1; i <= quatity; i++)
            {
                this.clone = PhotonNetwork.Instantiate(prefabName, posisionSpawn, Quaternion.identity);
                Debug.Log("Spawn: " + clone.name + "-in Photon");
                Debug.Log(Path.Combine("Effects","aaaaa"));
            }
        }
        else
        {
            for (int i = 1; i <= quatity; i++)
            {
                this.clone = Instantiate(prefab, posisionSpawn, Quaternion.identity);
                this.clone.transform.SetParent(parent);
                Debug.Log("Spawn: " + clone.name + "-in Offline");
            }
        }
        
    }
}

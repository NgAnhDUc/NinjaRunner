using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform parent;
    public int quatity =1 ;
    public Vector3 posisionSpawn;
    public GameObject clone;
    
    public void SpawnPrefabs(GameObject prefab, Transform parent, int quantity, Vector3 posisionSpawn)
    {
        for(int i = 1; i <= quatity;i++)
        {
            this.clone = Instantiate(prefab, posisionSpawn, Quaternion.identity);
            this.clone.transform.SetParent(parent);
        }
    }
}

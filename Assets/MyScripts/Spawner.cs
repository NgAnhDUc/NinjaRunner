using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform parent;
    public int quatity =1 ;
    public Vector3 posisionSpawn;
    
    public void SpawnPrefabs(GameObject prefab, Transform parent, int quantity, Vector3 posisionSpawn)
    {
        for(int i = 1; i > quatity;i++)
        {
            GameObject clone = Instantiate(prefab, posisionSpawn, Quaternion.identity);
            clone.transform.SetParent(parent);
        }
    }
}

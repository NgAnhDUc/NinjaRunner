using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : Spawner
{
    private void Reset()
    {
        this.prefab = Resources.Load<GameObject>("Player");
        this.parent = transform;
        posisionSpawn = transform.position;
    }
    private void Awake()
    {
        this.Reset();
    }
    private void Start()
    {
        this.SpawnPrefabs(this.prefab, this.parent, this.quatity, this.posisionSpawn);
    }
}

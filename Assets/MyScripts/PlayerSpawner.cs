using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : Spawner
{
    public GameObject effectSpawn;
    private void Reset()
    {
        this.prefab = Resources.Load<GameObject>("Player");
        this.effectSpawn = Resources.Load<GameObject>("Effects/EffectSpawn");
        this.parent = transform;
        this.posisionSpawn = transform.position;

    }
    private void Awake()
    {
        this.Reset();
    }
    private void Start()
    {
        Vector3 effectSpawmPos = new Vector3(posisionSpawn.x,posisionSpawn.y+1.28f,posisionSpawn.z);
        this.SpawnPrefabs(this.effectSpawn, this.parent, this.quatity, effectSpawmPos);
        Invoke("SpawnPlayer", 0);
        
    }
    protected void SpawnPlayer()
    {
        this.SpawnPrefabs(this.prefab, this.parent, this.quatity, this.posisionSpawn);
    }
}

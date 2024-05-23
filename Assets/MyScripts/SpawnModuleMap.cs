using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnModuleMap : Spawner
{
    public bool isSpawn = false;

    private void Reset()
    {
        this.prefab = Resources.Load<GameObject>("MapModules/Map Module");
        this.parent = GameObject.Find("Map Modules").transform;
    }

    private void Awake()
    {
        this.Reset();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isSpawn) return;
        if (collision.gameObject.tag == "Player")
        {
            this.posisionSpawn = new Vector3(transform.position.x + 100f, 0, 0);
            string name = "MapModules/Map Module";
            this.SpawnPrefabs(prefab, parent, quatity, posisionSpawn,name);

            isSpawn = true;
        }
    }
}

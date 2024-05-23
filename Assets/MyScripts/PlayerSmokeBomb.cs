using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerSmokeBomb : Spawner
{
    public float count = 0;
    public float reloadTime = 5;
    public Slider smokeBombSlider;
    public GameObject fillProcess;

    private void Reset()
    {
        this.prefab = Resources.Load<GameObject>("SmokeBomb");
        this.parent = GameObject.Find("Bullet Pool").transform;

        this.smokeBombSlider = GameObject.Find("SmokeBombSlider").GetComponent<Slider>();
        this.fillProcess = smokeBombSlider.transform.GetChild(1).GetChild(0).gameObject;

        smokeBombSlider.maxValue = reloadTime;
    }

    private void Awake()
    {
        this.Reset();
    }

    private void Update()
    {
        if (!photonView.IsMine && PhotonNetwork.IsConnected) return;
        count += Time.deltaTime;
        smokeBombSlider.value = count;
        if (count < reloadTime)
        {
            fillProcess.GetComponent<Image>().color = Color.red;
            return;
        }
        count = reloadTime;
        fillProcess.GetComponent<Image>().color = Color.green;

        if (Input.GetKeyDown(KeyCode.X))
        {
            this.posisionSpawn = new Vector3(transform.position.x - 1.2f, transform.position.y , transform.position.z);
            this.SpawnPrefabs(prefab, parent, quatity, posisionSpawn,prefab.name);
            count = 0;
        }
    }
}

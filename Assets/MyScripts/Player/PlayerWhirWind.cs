using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWhirWind : Spawner
{
    public float count = 0;
    public float reloadTime = 5;
    public Slider whirWindSlider;
    public GameObject fillProcess;

    private void Reset()
    {
        this.prefab = Resources.Load<GameObject>("WhirWind");
        this.parent = GameObject.Find("Bullet Pool").transform;

        this.whirWindSlider = GameObject.Find("WhirWindSlider").GetComponent<Slider>();
        this.fillProcess = whirWindSlider.transform.GetChild(1).GetChild(0).gameObject;

        whirWindSlider.maxValue = reloadTime;
    }

    private void Awake()
    {
        this.Reset();
    }

    private void Update()
    {
        if (!photonView.IsMine) return;
        count += Time.deltaTime;
        whirWindSlider.value = count;
        if (count < reloadTime)
        {
            fillProcess.GetComponent<Image>().color = Color.red;
            return;
        }
        count = reloadTime;
        fillProcess.GetComponent<Image>().color = Color.green;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.posisionSpawn = new Vector3(transform.position.x + 1.2f, transform.position.y + 0.35f, transform.position.z);
            this.SpawnPrefabs(prefab, parent, quatity, posisionSpawn,prefab.name);
            count = 0;
        }
    }
}

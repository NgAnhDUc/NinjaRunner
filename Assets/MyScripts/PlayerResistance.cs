using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResistance : Spawner
{
    public float count = 0;
    public float reloadTime = 5;
    public Slider resisSlider;
    public GameObject fillProcess;
    private void Reset()
    {
        this.prefab = Resources.Load<GameObject>("Resistance Axis");
        this.parent = transform;

        this.resisSlider = GameObject.Find("ResisSlider").GetComponent<Slider>();
        this.fillProcess = resisSlider.transform.GetChild(1).GetChild(0).gameObject;

        resisSlider.maxValue = reloadTime;
    }

    private void Awake()
    {
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        resisSlider.value = count;
        if (count < reloadTime)
        {
            fillProcess.GetComponent<Image>().color = Color.red;
            return;
        }
        count = reloadTime;
        fillProcess.GetComponent<Image>().color = Color.green;

        if (Input.GetKeyDown(KeyCode.C))
        {
            this.posisionSpawn = new Vector3(transform.position.x + 0.1f,transform.position.y + 0.5f,transform.position.z);
            this.SpawnPrefabs(prefab, parent, quatity, posisionSpawn);
            count = 0;
        }
    }
}

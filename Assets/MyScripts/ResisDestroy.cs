using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResisDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0) DestroyObject();
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}

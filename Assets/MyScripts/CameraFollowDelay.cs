using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowDelay : MonoBehaviour
{
    protected GameObject[] playerTransforms;
    public Transform playerTransform;
    public float smoothSpeed = 0.01f;
    public float delayDistance = 5.0f;
    public float offset = 8f; // distance offset camera to player

    private void Start()
    {
        Invoke("GetPlayerTranform", 0.5f);
    }
    private void LateUpdate()
    {
        if (this.playerTransform==null) return;
        Vector3 targetPosition = playerTransform.position;

        if (Vector3.Distance(transform.position, targetPosition) > delayDistance)
        {
            targetPosition = new Vector3(playerTransform.position.x + offset, 0) - transform.forward * delayDistance;
        }
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
    }
    protected void GetPlayerTranform()
    {
        this.playerTransforms = GameObject.FindGameObjectsWithTag("Player");
        this.playerTransform = playerTransforms[0].transform;
    }
}

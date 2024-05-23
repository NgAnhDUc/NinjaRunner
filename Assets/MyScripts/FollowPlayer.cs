using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    protected GameObject[] playerTransforms;
    public Transform playerTransform;
    public float smoothSpeed = 1f;
    public float offset = 0.5f;

    private void Start()
    {
        this.GetPlayerTranform();
    }

    private void LateUpdate()
    {
        if (this.playerTransform == null) return;
        Vector3 targetPosition = playerTransform.position;

        targetPosition = new Vector3(targetPosition.x,targetPosition.y );
        
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
    }

    protected void GetPlayerTranform()
    {
        this.playerTransforms = GameObject.FindGameObjectsWithTag("Player");
        this.playerTransform = playerTransforms[0].transform;
    }
}

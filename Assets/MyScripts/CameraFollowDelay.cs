using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowDelay : MonoBehaviour
{
    public Transform playerTransform;
    public float smoothSpeed = 0.01f;
    public float delayDistance = 5.0f;
    private Vector3 initialCameraPosition;
    public float offset = 8f; // distance offset camera to player

    private void Start()
    {
        initialCameraPosition = transform.position;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = playerTransform.position;

        if (Vector3.Distance(transform.position, targetPosition) > delayDistance)
        {
            targetPosition = new Vector3(playerTransform.position.x + offset, 0) - transform.forward * delayDistance;
        }

        
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
    }
}

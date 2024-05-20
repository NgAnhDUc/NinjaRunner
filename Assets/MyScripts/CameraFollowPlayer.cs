using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform target; // Reference to the player object
    [SerializeField] private float offsetX; // Desired offset from the player on the X-axis

    void LateUpdate()
    {
        if (target != null)
        {
            // Get the current camera position
            Vector3 cameraPosition = transform.position;

            // Update the camera's X position to follow the player with the desired offset
            cameraPosition.x = target.position.x + offsetX;

            // Set the new camera position
            transform.position = cameraPosition;
        }
        else
        {
            Debug.LogError("CameraFollowX: No target assigned!");
        }
    }
    private void Awake()
    {
        this.target = GameObject.FindWithTag("Player").transform;
        offsetX = 3;
    }
    
}

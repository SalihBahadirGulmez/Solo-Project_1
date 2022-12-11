using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    public float smoothSpeed = 10f;
    public Vector3 offset = new Vector3(0, 0.9f, -2.5f);

    private void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
       // Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = desiredPosition;

        transform.LookAt(player);
    }
}   

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform PlayerTransform;
    private Vector3 _cameraOffset;

    [Range(0.0f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAt = false;

    private void Start()
    {
        _cameraOffset = transform.position - PlayerTransform.position;
    }

    private void LateUpdate()
    {
        Vector3 newPosition = PlayerTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, SmoothFactor);
        if(LookAt)
        {
            transform.LookAt(PlayerTransform);
        }
    }
}

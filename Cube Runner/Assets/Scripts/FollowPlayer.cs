using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float offset;
    void Update()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.z = playerTransform.position.z + offset;
        transform.position = cameraPosition;
    }
}

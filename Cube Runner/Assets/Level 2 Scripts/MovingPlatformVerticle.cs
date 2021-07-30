using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformVerticle : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    bool movingUp = false;

    private void FixedUpdate()
    {
        if (movingUp == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.transform.position, Time.fixedDeltaTime * speed);
            if (transform.position.y == pointB.transform.position.y)
            {
                movingUp = true;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.transform.position, Time.fixedDeltaTime * speed);
            if (transform.position.y == pointA.transform.position.y)
            {
                movingUp = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Landed on moving platform, setting parent");
            other.transform.parent = this.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = null;
        }
    }
}

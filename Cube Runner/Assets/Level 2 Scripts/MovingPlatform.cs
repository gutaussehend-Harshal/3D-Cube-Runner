using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    bool movingLeft = false;

    private void FixedUpdate()
    {
        if (movingLeft == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.transform.position, Time.fixedDeltaTime * speed);
            if (transform.position.x == pointB.transform.position.x)
            {
                movingLeft = true;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.transform.position, Time.fixedDeltaTime * speed);
            if (transform.position.x == pointA.transform.position.x)
            {
                movingLeft = false;
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

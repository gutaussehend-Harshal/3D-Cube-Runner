using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private float force = 1000f;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float maxX, minX;
    void Start()
    {
        // Debug.Log("Player Position: " + transform.position);
    }

    void Update()
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);  // Restrict movement of player and keep in between max and min.
        // if (playerPos.x < minX)
        // {
        //     playerPos.x = minX;
        // }
        // if (playerPos.x > maxX)
        // {
        //     playerPos.x = maxX;
        // }
        transform.position = playerPos;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right arrow is pressed");
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left arrow is pressed");
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
    }

    private void FixedUpdate()
    {
        rigidBody.AddForce(0f, 0f, force * Time.deltaTime);
    }
}

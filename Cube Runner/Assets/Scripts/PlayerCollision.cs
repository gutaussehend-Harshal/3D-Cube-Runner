using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private ScoreController score;
    [SerializeField] private GameController gameController;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSource audioSource1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            score.addScore(10);
            other.gameObject.SetActive(false);
            // Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            audioSource1.Play();
            gameController.gameOver();
            playerController.enabled = false;
        }
    }
}

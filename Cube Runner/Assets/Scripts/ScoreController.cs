using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI finalScoreText;
    [SerializeField] private int myScore = 0;
    void Update()
    {
        scoreText.text = "Score: " + myScore.ToString();
        finalScoreText.text = "Total Score: " + myScore.ToString();
    }

    public void addScore(int score)
    {
        myScore += score;
    }
}

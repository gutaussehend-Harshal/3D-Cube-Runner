using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] private string sceneName;

    [SerializeField] private Button restartButton;
    [SerializeField] private GameObject tapToStart;
    [SerializeField] private GameObject scoreText;

    private void Start()
    {
        pauseGame();
        tapToStart.SetActive(true);
        gameOverPanel.SetActive(false);
        scoreText.SetActive(false);
        restartButton.onClick.AddListener(restart);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            startGame();
        }
    }
    public void gameOver()
    {
        gameOverPanel.SetActive(true);
        scoreText.SetActive(false);
    }

    private void restart()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    private void pauseGame()
    {
        Time.timeScale = 0f;
    }
    private void startGame()
    {
        tapToStart.SetActive(false);
        scoreText.SetActive(true);
        Time.timeScale = 1f;
    }
}

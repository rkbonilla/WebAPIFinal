using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private void Update()
    {
        Scene currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        
        if (sceneName != "GameOver" && GameManager.instance.gameTimer <= 0)
        {
            LoadGameOver();
        }
    }

    public void LoadGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    public void LoadHighScores()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HighScores");
    }

    public void LoadMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void LoadGameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

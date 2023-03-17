using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private TMP_Text gameOverText;
    [SerializeField] private GameObject usernameInput;
    [SerializeField] private GameObject usernameSubmit;
    [SerializeField] private VerticalLayoutGroup buttonVLG;

    private void Awake()
    {
        GameManager.instance.gameTimer = 10;

        if (GameManager.instance.score > GameManager.instance.currentHighScore)
        {
            buttonVLG.spacing = -300;
            usernameInput.SetActive(true);
            usernameSubmit.SetActive(true);
            GameManager.instance.currentHighScore = GameManager.instance.score;
            gameOverText.text = "Game Over!\nYour score was " + GameManager.instance.score.ToString() +
                "!\nNEW HIGH SCORE!";
        }
        else
        {
            buttonVLG.spacing = -380;
            usernameInput.SetActive(false);
            usernameSubmit.SetActive(false);
            gameOverText.text = "Game Over!\nYour score was " + GameManager.instance.score.ToString() +
                "!\nNo high score, try again!" +
                "\nCurrent high score: " + GameManager.instance.currentHighScore.ToString();
        }

        GameManager.instance.score = 0;
    }
}

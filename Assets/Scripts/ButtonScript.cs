using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private GameSceneScript gameSceneScript;
    
    public void RedScore()
    {
        if (gameSceneScript.colorChoice == "Red")
        {
            GameManager.instance.score += 1;
            gameSceneScript.scoreText.text = "Score: " + GameManager.instance.score.ToString();
        }
    }
    
    public void BlueScore()
    {
        if (gameSceneScript.colorChoice == "Blue")
        {
            GameManager.instance.score += 1;
            gameSceneScript.scoreText.text = "Score: " + GameManager.instance.score.ToString();
        }
    }

    public void GreenScore()
    {
        if (gameSceneScript.colorChoice == "Green")
        {
            GameManager.instance.score += 1;
            gameSceneScript.scoreText.text = "Score: " + GameManager.instance.score.ToString();
        }
    }
}

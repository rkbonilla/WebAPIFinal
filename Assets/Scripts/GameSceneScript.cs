using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSceneScript : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timerText;
    [SerializeField] private TMP_Text colorText;
    
    public string colorChoice = "";

    // Make an array that holds 3 different strings: Red, Green, and Blue
    private string[] colors = new string[3] { "Red", "Green", "Blue" };

    private void Awake()
    {
        StartCoroutine(Countdown());
        StartCoroutine(ChangeColor());
    }

    void Update()
    {
        if (GameManager.instance.gameTimer <= 0)
            StopAllCoroutines();

        timerText.text = "Time: " + GameManager.instance.gameTimer.ToString();
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(1);
        GameManager.instance.gameTimer -= 1;
        StartCoroutine(Countdown());
    }

    IEnumerator ChangeColor()
    {
        yield return new WaitForSeconds(0.5f);
        colorChoice = colors[Random.Range(0, 3)];
        
        if (colorChoice == "Red")
        {
            colorText.color = Color.red;
            colorText.text = colorChoice;
        }
        else if (colorChoice == "Blue")
        {
            colorText.color = Color.blue;
            colorText.text = colorChoice;
        }
        else if (colorChoice == "Green")
        {
            colorText.color = Color.green;
            colorText.text = colorChoice;
        }
        
        StartCoroutine(ChangeColor());
    }
}

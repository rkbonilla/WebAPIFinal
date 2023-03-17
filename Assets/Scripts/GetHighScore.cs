using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Networking;
using TMPro;
using System.Text;
using Newtonsoft.Json;
using UnityEngine.UIElements;
using UnityEngine.SocialPlatforms.Impl;
using System;

[Serializable]
public class GetHighScore : MonoBehaviour
{
    private string userName;
    private int userScore;
    
    private void Awake()
    {
        StartCoroutine(GetRequest("http://localhost:3000/api/highestScore")); 
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest getRequest = UnityWebRequest.Get(uri))
        {
            yield return getRequest.SendWebRequest();

            if (getRequest.responseCode == 404)
                GameManager.instance.currentHighScore = 0;
            else
            {
                var newData = System.Text.Encoding.UTF8.GetString(getRequest.downloadHandler.data);
                var newGetRequestData = JsonUtility.FromJson<PlayerData>(newData);

                GameManager.instance.currentHighScore = newGetRequestData.userScore;
            }

            Debug.Log("Current high score: " + GameManager.instance.currentHighScore);
        }
    }
}

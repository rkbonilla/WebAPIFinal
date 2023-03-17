using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

[Serializable]
public class HighScoreController : MonoBehaviour
{
    public TMP_Text highScoreText;

    IEnumerator GetRequest(string uri)
    {
        using UnityWebRequest getRequest = UnityWebRequest.Get(uri);
        {
            yield return getRequest.SendWebRequest();

            var newData = Encoding.UTF8.GetString(getRequest.downloadHandler.data);
            Players players = JsonConvert.DeserializeObject<Players>(newData);

            foreach (var entry in players.players)
            {
                highScoreText.text +=
                    "Username: " + entry.userName + "\tScore: " + entry.userScore + "\n\n";
            }
        }
    }

    private void Awake()
    {
        StartCoroutine(GetRequest("http://localhost:3000/api/getPlayerScoresUnity"));
    }
}

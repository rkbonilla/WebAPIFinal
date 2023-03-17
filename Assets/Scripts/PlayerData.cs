using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData
{
    public string userName;
    public int userScore;
}

public class Players
{
    public PlayerData[] players { get; set; }
}

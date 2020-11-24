using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels
{
    public void All_Levels()
    {
        PlayerData playerData = new PlayerData();

        switch (Player.levelNum)
        {
            case 1:
                playerData.level = 1;
                playerData.words = new string[] { "cat", "act" };
                playerData.letters = "cat";
                break;
            case 2:                
                playerData.level = 2;
                playerData.words = new string[] { "won", "own", "now" };
                playerData.letters = "won";
                break;
            case 3:
                playerData.level = 3;
                playerData.words = new string[] { "ear", "are", "era" };
                playerData.letters = "ear";
                break;
            default:
                break;
        }
    }
}

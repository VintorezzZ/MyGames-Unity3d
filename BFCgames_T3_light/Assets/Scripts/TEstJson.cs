using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TEstJson : MonoBehaviour
{

    //Player[] player = JsonHelper.FromJson<Player>(jsonString);
    //Debug.Log(player[0].playerLoc);
    //Debug.Log(player[1].playerLoc);

    public void Load()
    {
        if (File.Exists(Application.dataPath + "/Resources/Levels.json"))
        {
            string savedString = File.ReadAllText(Application.dataPath + "/Resources/Levels.json");
            //Debug.Log("Loaded: " + savedString);

            PlayerData[] playerData = JsonUtility.FromJson<PlayerData[]>(savedString);

            Debug.Log("data: " + playerData);
            Debug.Log(playerData[0].letters);
            Debug.Log(playerData[1].letters);

            int levelNum = playerData[2].level;
            string[] words = playerData[2].words;
            string letters = playerData[2].letters;
        }
        else
            Debug.Log("No save!");
    }






    void Start()
    {
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

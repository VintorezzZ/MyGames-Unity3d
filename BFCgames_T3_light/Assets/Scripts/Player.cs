using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Text wordsBlock;
    [SerializeField]
    private Text TextLevel = null;
    [SerializeField]
    public static int levelNum;
    [SerializeField]
    public static string[] words;
    [SerializeField]
    public static string letters;
    //public string[] words = {"cat", "act"};
    //public string letters = "cat";

    private void Awake()
    {
        //PlayerData playerData = new PlayerData { 
        //    level = 1, 
        //    words = new string[] { "cat", "act" }, 
        //    letters = "cat" };
        //string json = JsonUtility.ToJson(playerData);
        //Debug.Log(json);

        //PlayerData loadedPlayerdata = JsonUtility.FromJson<PlayerData>(json);
        //Debug.Log(loadedPlayerdata.level);
    }
    private void Start()
    {
        Load();
        TextLevel.text = "Уровень " + levelNum.ToString();
    }

    public void Update()
    {
        LoadOnClick();
        //TextLevel.text = "Уровень " + levelNum.ToString();

        //wordsBlock.text = letters;
    }


    public static void Save()
    {
        int currentLevel = levelNum;
        string[] currentWords = words;
        string currentLetters = letters;

        PlayerData playerData = new PlayerData { level = currentLevel, words = currentWords, letters = currentLetters };
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(Application.dataPath + "/Resources/Save.txt", json);
        Debug.Log("Saved!");
    }

    public void Load()
    {
        if (File.Exists(Application.dataPath + "/Resources/Save.txt"))
        {
            string savedString = File.ReadAllText(Application.dataPath + "/Resources/Save.txt");
            Debug.Log("Loaded: " + savedString);

            PlayerData playerData = JsonUtility.FromJson<PlayerData>(savedString);

            levelNum = playerData.level;
            words = playerData.words;
            letters = playerData.letters;

            Debug.Log("level: " + levelNum);
            Debug.Log("words: ");
            foreach (var i in words)
            {
                Debug.Log(i);
            }
            Debug.Log("letters: " + letters);
        }
        else
        {
            Debug.Log("No save! Loading default level...");

            levelNum = 1;
            words = new string[] { "cat", "act" };
            letters = "cat"; 
        }
    }

    public void ChangeLevel()
    {
        levelNum += 1;
        TextLevel.text = "Уровень " + levelNum.ToString();
        Debug.Log("Level changed!");
    }

    public void LoadOnClick()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Load();
            Debug.Log("Loaded!!!");
        }
    }
}

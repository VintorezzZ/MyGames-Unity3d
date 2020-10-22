﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaticButtons : MonoBehaviour
{
    [SerializeField] GameObject pausePanel; 
    [SerializeField] GameObject startPanel; 
    public void StartGame()
    {
        startPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Unpause()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
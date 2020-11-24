using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject Overlay;
    public GameObject Window_extra;

    public void OnBackButtonClick()
    {
        Player.Save();
        SceneManager.LoadScene(0);
    }

    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExtraButtonClick()
    {
        Overlay.SetActive(true);
        Window_extra.SetActive(true);
    }

    public void OnExtraButtonCloseClick()
    {
        Overlay.SetActive(false);
        Window_extra.SetActive(false);
    }
}

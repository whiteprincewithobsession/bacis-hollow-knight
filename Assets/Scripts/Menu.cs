using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void clickStartButton()
    {

        PlayerPrefs.SetInt("_shieldAchieved", 0);
        PlayerPrefs.SetString("Milestone", "Spawn");
        clickLoadButton();
    }
    public void clickLoadButton()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("Milestone"));
    }
    public void clickQuitButton()
    {
        Application.Quit();
    }
    public void clickSettingsButton()
    {
        SceneManager.LoadScene("Settings");
    }
}

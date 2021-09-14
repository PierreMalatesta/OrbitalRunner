using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void LoadStore()
    {
        SceneManager.LoadScene("Store");
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("LevelScene");
        
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
}

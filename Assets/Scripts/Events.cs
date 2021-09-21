using UnityEngine.SceneManagement;
using UnityEngine;
using System.Diagnostics;

public class Events : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("test");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ReplayLvlOne()
    {
        SceneManager.LoadScene("Level1");

    }

    public void ReplayLvlTwo()
    {
        SceneManager.LoadScene("Level2");

    }

    public void ReplayLvlThree()
    {
        SceneManager.LoadScene("Level3");

    }

    public void ReplayLvlfour()
    {
        SceneManager.LoadScene("Level4");
    }

    public void ReplayLvlfive()
    {
        SceneManager.LoadScene("Level5");
    }

}

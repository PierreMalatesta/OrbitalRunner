using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject Panel; 

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true); 
        }

    }

public void PauseThisGame()
    {
        if (Time.timeScale == 1)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void ResumeGame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            Panel.SetActive(false); 
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject FinishPanel;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            FinishPanel.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            FinishPanel.SetActive(false);
        }
    }
}

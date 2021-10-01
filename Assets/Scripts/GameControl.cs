using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public Text moneyText;
    public static int moneyAmount;
    int isNinjaSold;
    public GameObject Ninja;
    public GameObject FirstPlayer;

    // public GameObject FirstPlayer;

    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        isNinjaSold = PlayerPrefs.GetInt("IsNinjaSold");

        if (isNinjaSold == 1)
        {
            Ninja.SetActive(true);
            FirstPlayer.SetActive(false);
        }
        else
        {
            Ninja.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money: " + moneyAmount.ToString() + "$";
    }

    public void gotoShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("Store");
    }
}

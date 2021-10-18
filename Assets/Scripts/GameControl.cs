using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Checks game to see if ninja has been bought if so disables first character and enables ninja, it also disables the first pair of buttons "Jump and slide". This works in with the shopControl script
/// </summary>
public class GameControl : MonoBehaviour
{
    public Text moneyText;
    public static int moneyAmount;
    int isNinjaSold;
    public GameObject Ninja;
    public GameObject FirstPlayer;
    public GameObject SecondJump;
    public GameObject SecondSlide;

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
            SecondJump.SetActive(true);
            SecondSlide.SetActive(true);
        }
        else
        {
            Ninja.SetActive(false);
            SecondJump.SetActive(false);
            SecondSlide.SetActive(false);
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

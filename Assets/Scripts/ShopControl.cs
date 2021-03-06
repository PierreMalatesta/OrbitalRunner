using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// shopControl gets total money and checks if ninja has been bought if so deletes 10 coins.
/// </summary>
public class ShopControl : MonoBehaviour
{
    int moneyAmount;
    int isNinjaSold;

    public Text moneyAmountText;
    public Text ninjaPrice;

    public Button buyButton;

    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    // Update is called once per frame
    void Update()
    {
        moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";

        isNinjaSold = PlayerPrefs.GetInt("isNinjaSold");

        if (moneyAmount >= 10 && isNinjaSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;
    }

    /// <summary>
    /// This function is use to buy the ninja gameObject, takes away 10 coins and disables the buy button.
    /// </summary>

    public void buyNinja()
    {
        moneyAmount -= 10;
        PlayerPrefs.SetInt("IsNinjaSold", 1);
        ninjaPrice.text = "Sold!";
        buyButton.gameObject.SetActive(false);
    }

    public void exitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("Test");
    }

    public void resetPlayerPrefs()
    {
        moneyAmount = 0;
        buyButton.gameObject.SetActive(true);
        ninjaPrice.text = "Price: 10$";
        PlayerPrefs.DeleteAll();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    private float coin = 0;

    public TextMeshProUGUI TextCoins;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            coin++;
            TextCoins.text = coin.ToString();
        }
    }
}

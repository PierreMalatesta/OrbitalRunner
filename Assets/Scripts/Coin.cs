using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    private float coin = 0;

    public TextMeshProUGUI TextCoins;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "coin")
        {
            coin++;
            TextCoins.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
}

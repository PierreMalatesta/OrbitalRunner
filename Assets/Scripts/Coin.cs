using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin : MonoBehaviour
{
    //private float coin = 0;

    //public TextMeshProUGUI TextCoins;

    private void OnTriggerEnter(Collider col)
    {
            GameControl.moneyAmount += 1;
            Destroy(gameObject);
     
    }
}

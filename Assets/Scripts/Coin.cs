using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float coin = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "coin")
        {
            Destroy(other.gameObject);
        }
    }
}

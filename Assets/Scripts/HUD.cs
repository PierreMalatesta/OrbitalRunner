using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] GameObject ObjectToDestroy;

    public void hudDisable()
    {
        DestroyImmediate(ObjectToDestroy, true); 
    }
}

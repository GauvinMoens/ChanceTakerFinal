using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public static PowerUpManager instance { get; private set; }

    private void Awake()
    {
        instance = this; 
    }

    public void Add2P2()
    {

    }
}

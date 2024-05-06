using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class DiceResultGenerator : MonoBehaviour
{
    public static int numberGenerated1;
    public static int numberGenerated2;
    public static void NumberGen1()
    {
        if(DiceRollingManager.diceRolledP1 == 0)
        {
            // numberGenerated1 = Random.Range(1,4);
            numberGenerated1 = 1;
        }
        if (DiceRollingManager.diceRolledP1 == 1)
        {
            numberGenerated1 = Random.Range(1, 6);
        }
        if (DiceRollingManager.diceRolledP1 == 2)
        {
            numberGenerated1 = Random.Range(1, 8);
        }
        if (DiceRollingManager.diceRolledP1 == 3)
        {
            numberGenerated2 = Random.Range(1, 12);
        }
        if (DiceRollingManager.diceRolledP1 == 4)
        {
            numberGenerated1 = Random.Range(1, 12);
        }
        if (DiceRollingManager.diceRolledP1 == 5)
        {
            numberGenerated1 = Random.Range(1, 20);
        }
        Debug.Log(DiceRollingManager.diceRolledP1 + " " + numberGenerated1);
    }
    public static void NumberGen2()
    {
        if (DiceRollingManager.diceRolledP2 == 0)
        {
            //numberGenerated2 = Random.Range(1, 4);
            numberGenerated2 = 1;
        }
        if (DiceRollingManager.diceRolledP2 == 1)
        {
            numberGenerated2 = Random.Range(1, 6);
        }
        if (DiceRollingManager.diceRolledP2 == 2)
        {
            numberGenerated2 = Random.Range(1, 8);
        }
        if (DiceRollingManager.diceRolledP2 == 3)
        {
            numberGenerated2 = Random.Range(1, 12);
        }
        if (DiceRollingManager.diceRolledP2 == 4)
        {
            numberGenerated2 = Random.Range(1, 12);
        }
        if (DiceRollingManager.diceRolledP2 == 5)
        {
            numberGenerated2 = Random.Range(1, 20);
        }
        Debug.Log(DiceRollingManager.diceRolledP2 + " " + numberGenerated2);
    }

    public static void numberGenInEqualCaseP1()
    {
        numberGenerated1 = Random.Range(1, 6);
    }
    public static void numberGenInEqualCaseP2()
    {
        numberGenerated2 = Random.Range(1, 6);
    }
}

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
        if(ThrowDice.diceRolled == 0)
        {
            numberGenerated1 = Random.Range(1,4);
        }
        if (ThrowDice.diceRolled == 1)
        {
            numberGenerated1 = Random.Range(1, 6);
        }
        if (ThrowDice.diceRolled == 2)
        {
            numberGenerated1 = Random.Range(1, 8);
        }
        if (ThrowDice.diceRolled == 3)
        {
            numberGenerated2 = Random.Range(1, 12);
        }
        if (ThrowDice.diceRolled == 4)
        {
            numberGenerated1 = Random.Range(1, 12);
        }
        if (ThrowDice.diceRolled == 5)
        {
            numberGenerated1 = Random.Range(1, 20);
        }
        Debug.Log(ThrowDice.diceRolled + " " + numberGenerated1);
    }
    public static void NumberGen2()
    {
        if (ThrowDice.diceRolled == 0)
        {
            numberGenerated2 = Random.Range(1, 4);
        }
        if (ThrowDice.diceRolled == 1)
        {
            numberGenerated2 = Random.Range(1, 6);
        }
        if (ThrowDice.diceRolled == 2)
        {
            numberGenerated2 = Random.Range(1, 8);
        }
        if (ThrowDice.diceRolled == 3)
        {
            numberGenerated2 = Random.Range(1, 12);
        }
        if (ThrowDice.diceRolled == 4)
        {
            numberGenerated2 = Random.Range(1, 12);
        }
        if (ThrowDice.diceRolled == 5)
        {
            numberGenerated2 = Random.Range(1, 20);
        }
        Debug.Log(ThrowDice.diceRolled + " " + numberGenerated2);
    }
}

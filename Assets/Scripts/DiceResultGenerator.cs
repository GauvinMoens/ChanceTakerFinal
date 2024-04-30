using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class DiceResultGenerator : MonoBehaviour
{
    public static NetworkVariable<int> numberGenerated;

    public static void NumberGen()
    {
        if(ThrowDice.diceRolled == 0)
        {
            numberGenerated = new NetworkVariable<int>(Random.Range(1,4));
        }
        if (ThrowDice.diceRolled == 1)
        {
            numberGenerated = new NetworkVariable<int>(Random.Range(1, 6));
        }
        if (ThrowDice.diceRolled == 2)
        {
            numberGenerated = new NetworkVariable<int>(Random.Range(1, 8));
        }
        if (ThrowDice.diceRolled == 3)
        {
            numberGenerated = new NetworkVariable<int>(Random.Range(1, 12));
        }
        if (ThrowDice.diceRolled == 4)
        {
            numberGenerated = new NetworkVariable<int>(Random.Range(1, 20));
        }
    }
}

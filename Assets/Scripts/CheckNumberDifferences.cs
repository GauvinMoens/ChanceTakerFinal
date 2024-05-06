using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNumberDifferences : MonoBehaviour
{
    public static CheckNumberDifferences Instance { get; private set; }

    int resultOfTheRollP1;
    int resultOfTheRollP2;
    [SerializeField] private GameObject[] DiceP1;
    [SerializeField] private GameObject[] DiceP2;
    [SerializeField] private Rigidbody[] rbDiceP1;
    [SerializeField] private Rigidbody[] rbDiceP2;
    [SerializeField] GameObject player1, player2;

    private void Awake()
    {
        Instance = this;
    }

    public void CheckDifferenceBetweenResultNumbers()
    {
        resultOfTheRollP1 = DiceResultGenerator.numberGenerated1;
        resultOfTheRollP2 = DiceResultGenerator.numberGenerated2;

        if(resultOfTheRollP1 == resultOfTheRollP2 )
        {
            //Call Reroll script with D6
            player1.SetActive( false );
            player2.SetActive( false );
            ReRollinEqualCase.Instance.ReRollEqualCase();

        }else if(resultOfTheRollP1 < resultOfTheRollP2)
        {
            //P1 looses the round
            DiceP1[DiceRollingManager.currentDiceP1].SetActive(false);
            rbDiceP1[DiceRollingManager.currentDiceP1].isKinematic = true;
            DiceP1[DiceRollingManager.currentDiceP1].transform.position = ThrowDice.startingPositionP1[DiceRollingManager.currentDiceP1];
            rbDiceP2[DiceRollingManager.currentDiceP2].isKinematic = true;
            DiceP2[DiceRollingManager.currentDiceP2].transform.position = ThrowDice1.startingPositionP2[DiceRollingManager.currentDiceP2];
        }
        else
        {
            //P2 looses the round
            DiceP2[DiceRollingManager.currentDiceP2].SetActive(false);
            rbDiceP2[DiceRollingManager.currentDiceP2].isKinematic = true;
            DiceP2[DiceRollingManager.currentDiceP2].transform.position = ThrowDice1.startingPositionP2[DiceRollingManager.currentDiceP2];
            rbDiceP1[DiceRollingManager.currentDiceP1].isKinematic = true;
            DiceP1[DiceRollingManager.currentDiceP1].transform.position = ThrowDice.startingPositionP1[DiceRollingManager.currentDiceP1];
        }
    }
}

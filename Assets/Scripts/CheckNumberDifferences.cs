using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckNumberDifferences : MonoBehaviour
{
    public static CheckNumberDifferences Instance { get; private set; }

    public static int player1DiceLeft = 6;
    public static int player2DiceLeft = 6;

    public static bool[] diceP1Out = new bool[6];
    public static bool[] diceP2Out = new bool[6];

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

    private void Update()
    {
        if (player1DiceLeft == 0)
        {
            //player 2 win splash screen
            player2WinTheGame();
        }

        if (player2DiceLeft == 0)
        {
            //player 1 win splash screen
            player1WinTheGame();
        }
    }

    public void CheckLastChanceNbP1()
    {
       
        if(ThrowDice.lastChanceNb == resultOfTheRollP1)
        {
            DiceP1[ThrowDice.lastChanceDice].SetActive(true);
            diceP1Out[ThrowDice.lastChanceDice] = false;
            ++player1DiceLeft;
        }
        
        ThrowDice.lastChanceNb = 1;
    }

    public void CheckLastChanceNbP2()
    {
        if (ThrowDice1.lastChanceNb == resultOfTheRollP2)
        {
            DiceP2[ThrowDice1.lastChanceDice].SetActive(true);
            diceP2Out[ThrowDice1.lastChanceDice] = false;
            ++player2DiceLeft;
        }

        ThrowDice1.lastChanceNb = 1;
    }

    public void CheckDifferenceBetweenResultNumbers()
    {
        resultOfTheRollP1 = DiceResultGenerator.numberGenerated1;
        resultOfTheRollP2 = DiceResultGenerator.numberGenerated2;

        if(resultOfTheRollP1 == resultOfTheRollP2 )
        {
            //Call Reroll script with D6
            
            //reroll splash screen
            player1.SetActive( false );
            player2.SetActive( false );
            //Add delay
            ReRollinEqualCase.Instance.ReRollEqualCase();

        }else if(resultOfTheRollP1 < resultOfTheRollP2)
        {
            //P1 looses the round

            //Which players won splash screen


            //add delay on the disabled enabled
            Invoke("player2Win", 4);
        }
        else
        {
            //P2 looses the round

            //Which players won splash screen


            //add delay on the disabled enabled
            Invoke("player1Win", 4);
        }
    }

    public void player1Win()
    {
        --player2DiceLeft;
        //Add particule system for destruction

        DiceP2[DiceRollingManager.currentDiceP2].SetActive(false);
        diceP2Out[DiceRollingManager.currentDiceP2] = true;
        rbDiceP2[DiceRollingManager.currentDiceP2].isKinematic = true;
        DiceP2[DiceRollingManager.currentDiceP2].transform.position = ThrowDice1.startingPositionP2[DiceRollingManager.currentDiceP2];
        //Add particule system for respawn
        rbDiceP1[DiceRollingManager.currentDiceP1].isKinematic = true;
        DiceP1[DiceRollingManager.currentDiceP1].transform.position = ThrowDice.startingPositionP1[DiceRollingManager.currentDiceP1];
    }

    public void player2Win()
    {
        --player1DiceLeft;
        DiceP1[DiceRollingManager.currentDiceP1].SetActive(false);
        diceP1Out[DiceRollingManager.currentDiceP1] = true;
        rbDiceP1[DiceRollingManager.currentDiceP1].isKinematic = true;
        DiceP1[DiceRollingManager.currentDiceP1].transform.position = ThrowDice.startingPositionP1[DiceRollingManager.currentDiceP1];
        rbDiceP2[DiceRollingManager.currentDiceP2].isKinematic = true;
        DiceP2[DiceRollingManager.currentDiceP2].transform.position = ThrowDice1.startingPositionP2[DiceRollingManager.currentDiceP2];
        
    }

    private void player1WinTheGame()
    {
        GameManager.instance.QuitButton();
    }
    private void player2WinTheGame()
    {
      GameManager.instance.QuitButton();
    }
}

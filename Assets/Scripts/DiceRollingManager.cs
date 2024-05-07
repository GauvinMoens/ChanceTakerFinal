using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRollingManager : MonoBehaviour
{
    public static DiceRollingManager Instance { get; private set; }

    [SerializeField] Rigidbody[] diceRbP1;
    float[] p_randNegPosXP1 = new float[6];
    public static int diceRolledP1;
    public static int currentDiceP1;
    public static float strenghtP1;

    public static int currentDiceP2;
    float[] p_randNegPosXP2 = new float[6];
    [SerializeField] Rigidbody[] diceRbP2;
    public static int diceRolledP2;
    public static float strenghtP2;


    [SerializeField] float strenghtMultiplier = 3;
    [SerializeField] float strenghtRotMultiplier = 5;
    [SerializeField] float strenghtVerticalMultiplier = 4;

    

    public static int rollingCondition;
    float p_speed = 50;



    private void Start()
    {
        Instance = this;
        diceRbP1[0].isKinematic = true;
        diceRbP1[1].isKinematic = true;
        diceRbP1[2].isKinematic = true;
        diceRbP1[3].isKinematic = true;
        diceRbP1[4].isKinematic = true;
        diceRbP1[5].isKinematic = true;

        diceRbP2[0].isKinematic = true;
        diceRbP2[1].isKinematic = true;
        diceRbP2[2].isKinematic = true;
        diceRbP2[3].isKinematic = true;
        diceRbP2[4].isKinematic = true;
        diceRbP2[5].isKinematic = true;
    }

    private void Update()
    {
        
    }

  
    public void Roll()
    {
        ++rollingCondition;

        if (rollingCondition == 2)
        {
            float randXP1 = Random.Range(0f, 1f);
            float randYP1 = Random.Range(0f, 1f);
            float randZP1 = Random.Range(0f, 1f);

            for (int n = 0; n < 6; ++n)
            {
                p_randNegPosXP1[n] = Random.Range(-0.5f, 0.5f);
            }

            diceRbP1[currentDiceP1].isKinematic = false;

            diceRbP1[currentDiceP1].AddForce(Vector3.up * strenghtP1 * Time.deltaTime * strenghtVerticalMultiplier, ForceMode.Impulse);
            diceRbP1[currentDiceP1].AddForce(new Vector3(1, 0, p_randNegPosXP1[currentDiceP1]) * Time.deltaTime * strenghtMultiplier * p_speed * 4, ForceMode.Impulse);
            diceRbP1[currentDiceP1].AddTorque(new Vector3(randXP1, randYP1, randZP1) * strenghtP1 * strenghtRotMultiplier, ForceMode.Impulse);
            diceRolledP1 = currentDiceP1;
            Debug.Log(currentDiceP1); 
            DiceResultGenerator.NumberGen1();

            //Instantiate the number sprite on the Dice after 2 sec delay


            float randXP2 = Random.Range(0f, 1f);
            float randYP2 = Random.Range(0f, 1f);
            float randZP2 = Random.Range(0f, 1f);

            for (int n = 0; n < 6; ++n)
            {
                p_randNegPosXP2[n] = Random.Range(-0.5f, 0.5f);
            }
            
            diceRbP2[currentDiceP2].isKinematic = false;       
            diceRbP2[currentDiceP2].AddForce(Vector3.up * strenghtP2 * Time.deltaTime * strenghtVerticalMultiplier, ForceMode.Impulse);
            diceRbP2[currentDiceP2].AddForce(new Vector3(-1, 0, p_randNegPosXP2[currentDiceP2]) * Time.deltaTime * strenghtMultiplier * p_speed * 4, ForceMode.Impulse);
            diceRbP2[currentDiceP2].AddTorque(new Vector3(randXP2, randYP2, randZP2) * strenghtP2 * strenghtRotMultiplier, ForceMode.Impulse);
            diceRolledP2 = currentDiceP2;
            DiceResultGenerator.NumberGen2();

            //Instantiate the number sprite on the Dice after 2 sec delay

            //Add a delay and a splash screen with what player won the round

            if (CheckNumberDifferences.player1DiceLeft == 1)
            {
                CheckNumberDifferences.Instance.CheckLastChanceNbP1();
            }
            if (CheckNumberDifferences.player2DiceLeft == 1)
            {
                CheckNumberDifferences.Instance.CheckLastChanceNbP2();
            }
            CheckNumberDifferences.Instance.CheckDifferenceBetweenResultNumbers();

            rollingCondition = 0;
        }

    }
}

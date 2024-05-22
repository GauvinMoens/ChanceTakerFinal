using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRollingManager : MonoBehaviour
{
    public static DiceRollingManager Instance { get; private set; }

    [SerializeField] GameObject[] diceP1;
    [SerializeField] Rigidbody[] diceRbP1;
    float[] p_randNegPosXP1 = new float[6];
    public static int diceRolledP1;
    public static int currentDiceP1;
    public static float strenghtP1;

    [SerializeField] GameObject[] diceP2;
    public static int currentDiceP2;
    float[] p_randNegPosXP2 = new float[6];
    [SerializeField] Rigidbody[] diceRbP2;
    public static int diceRolledP2;
    public static float strenghtP2;


    [SerializeField] float strenghtMultiplier = 3;
    [SerializeField] float strenghtRotMultiplier = 5;
    [SerializeField] float strenghtVerticalMultiplier = 4;

    [SerializeField] GameObject camP1, camP2, camRoll;

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
        Debug.Log(rollingCondition);
        if (rollingCondition == 2)
        {
            camRoll.SetActive(true);
            camP2.SetActive(false);
            camP1.SetActive(false);


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
            if(currentDiceP1 == 0)
            {
                AudioManager.instance.P1D4Sound();
            }
            if (currentDiceP1 == 1)
            {
                AudioManager.instance.P1D6Sound();
            }
            if (currentDiceP1 == 2)
            {
                AudioManager.instance.P1D8Sound();
            }
            if (currentDiceP1 == 3)
            {
                AudioManager.instance.P1D10Sound();
            }
            if (currentDiceP1 == 4)
            {
                AudioManager.instance.P1D12Sound();
            }
            if (currentDiceP1 == 5)
            {
                AudioManager.instance.P1D20Sound();
            }
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
            if (currentDiceP2 == 0)
            {
                AudioManager.instance.P2D4Sound();
            }
            if (currentDiceP2 == 1)
            {
                AudioManager.instance.P2D6Sound();
            }
            if (currentDiceP2 == 2)
            {
                AudioManager.instance.P2D8Sound();
            }
            if (currentDiceP2 == 3)
            {
                AudioManager.instance.P2D10Sound();
            }
            if (currentDiceP2 == 4)
            {
                AudioManager.instance.P2D12Sound();
            }
            if (currentDiceP2 == 5)
            {
                AudioManager.instance.P2D20Sound();
            }
            DiceResultGenerator.NumberGen2();

            //Instantiate the number sprite on the Dice after 2 sec delay
            Invoke("TakePos", 1.5f);
            DiceResultGenerator.Instance.ShowNumberOfTheDice();
            //Add a delay and a splash screen with what player won the round

            CheckNumberDifferences.Instance.CheckDifferenceBetweenResultNumbers();
            if (CheckNumberDifferences.player1DiceLeft == 1)
            {
                CheckNumberDifferences.Instance.CheckLastChanceNbP1();
            }
            if (CheckNumberDifferences.player2DiceLeft == 1)
            {
                CheckNumberDifferences.Instance.CheckLastChanceNbP2();
            }

            rollingCondition = 0;

            Invoke("resetCam", 5);
        }

    }

    public void resetCam()
    {
        camRoll.SetActive(false);
        camP1.SetActive(true);
    }

    public void TakePos()
    {
        DiceResultGenerator.PosFaceP1 = new Vector3(diceP1[currentDiceP1].transform.position.x, diceP1[currentDiceP1].transform.position.y + 0.2f, diceP1[currentDiceP1].transform.position.z);
        DiceResultGenerator.PosFaceP2 = new Vector3(diceP2[currentDiceP2].transform.position.x, diceP2[currentDiceP2].transform.position.y + 0.2f, diceP2[currentDiceP2].transform.position.z);
    }
}

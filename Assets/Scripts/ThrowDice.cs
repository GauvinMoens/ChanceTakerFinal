using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ThrowDice : MonoBehaviour
{
    bool lastChanceSelection = false;

    [SerializeField] GameObject[] dice;
    [SerializeField] GameObject[] diceFaces;

    public static float p_strenght;
    [SerializeField] float strenghtMax = 150;
  
   
    int p_currentDice = 0;
    int p_numberOfDice = 6;

    public static bool p2Enabled = false;

    [SerializeField] Material[] mat1 = new Material[6];

    Renderer[] rend = new Renderer[6];

    public static Vector3[] startingPositionP1 = new Vector3[6];

    [SerializeField] GameObject changeLastChanceValUp, changeLastChanceValDown, changeLastChanceDiceUp, changeLastChanceDiceDown, currentLastChanceVal, currentLastChanceDice;
    [SerializeField] TextMeshProUGUI lastChanceNbText, lastChanceDiceSelectionText;
    public static int lastChanceNb = 1;
    public static int lastChanceDice = 1;
    void Start()
    {

        for (int i = 0; i < p_numberOfDice; i++)
        {
            startingPositionP1[i] = new Vector3(dice[i].transform.position.x, dice[i].transform.position.y, dice[i].transform.position.z);
            rend[i] = dice[i].GetComponent<Renderer>();
        }


        for (int i = 0; i < p_numberOfDice; i++)
        {
            rend[i].sharedMaterial = mat1[i];
            mat1[i].SetFloat("_LerpVal", 0);
        }
 
        mat1[0].SetFloat("_LerpVal", 1);
    }

    void Update()
    {
        if (CheckNumberDifferences.player1DiceLeft == 1)
        {
            changeLastChanceValUp.SetActive(true);
            changeLastChanceValDown.SetActive(true);
            changeLastChanceDiceUp.SetActive(true);
            changeLastChanceDiceDown.SetActive(true);
            currentLastChanceDice.SetActive(true);
            currentLastChanceVal.SetActive(true);
        }
        

        DiceSelection();

        ChangeColorOfTheSelectionText();

        Throw();
    }

    public void ChangeColorOfTheSelectionText()
    {
        if (CheckNumberDifferences.diceP1Out[0] == true)
        {
            if (lastChanceDice == 0)
                lastChanceDiceSelectionText.color = Color.red;
        }
        if (CheckNumberDifferences.diceP1Out[1] == true)
        {
            if (lastChanceDice == 1)
                lastChanceDiceSelectionText.color = Color.red;
        }
        if (CheckNumberDifferences.diceP1Out[2] == true)
        {
            if (lastChanceDice == 2)
                lastChanceDiceSelectionText.color = Color.red;
        }
        if (CheckNumberDifferences.diceP1Out[3] == true)
        {
            if (lastChanceDice == 3)
                lastChanceDiceSelectionText.color = Color.red;
        }
        if (CheckNumberDifferences.diceP1Out[4] == true)
        {
            if (lastChanceDice == 4)
                lastChanceDiceSelectionText.color = Color.red;
        }
        if (CheckNumberDifferences.diceP1Out[5] == true)
        {
            if (lastChanceDice == 5)
                lastChanceDiceSelectionText.color = Color.red;
        }
    }

    public void ChangeUpLastChanceNb()
    {
        if (ThrowDice1.p1Enabled == true)
        {
            if (lastChanceDice == 0)
            {
                if (lastChanceNb < 4)
                {
                    ++lastChanceNb;
                }
            }
            if (lastChanceDice == 1)
            {
                if (lastChanceNb < 6)
                {
                    ++lastChanceNb;
                }
            }
            if (lastChanceDice == 2)
            {
                if (lastChanceNb < 8)
                {
                    ++lastChanceNb;
                }
            }
            if (lastChanceDice == 3)
            {
                if (lastChanceNb < 10)
                {
                    ++lastChanceNb;
                }
            }
            if (lastChanceDice == 4)
            {
                if (lastChanceNb < 12)
                {
                    ++lastChanceNb;
                }
            }
            if (lastChanceDice == 5)
            {
                if (lastChanceNb < 20)
                {
                    ++lastChanceNb;
                }
            }
            lastChanceNbText.text = lastChanceNb.ToString();
        }
    }
    public void ChangeDownLastChanceNb()
    {
        if (ThrowDice1.p1Enabled == true)
        {
            if (lastChanceNb > 1)
            {
                --lastChanceNb;
            }
            lastChanceNbText.text = lastChanceNb.ToString();
        }
    }

    public void lastChanceDiceSelectionDown()
    {
        if (ThrowDice1.p1Enabled == true)
        {
            if (CheckNumberDifferences.diceP1Out[0] == false)
            {
                if (lastChanceDice > 0)
                {
                    --lastChanceDice;
                }
                int lastChanceDiceVar = lastChanceDice + 1;
                lastChanceDiceSelectionText.text = lastChanceDiceVar.ToString();
            }
            else
            {
                lastChanceDice = 1;
                int lastChanceDiceVar = lastChanceDice + 1;
                lastChanceDiceSelectionText.text = lastChanceDiceVar.ToString();
            }
        }
    }

    public void lastChanceDiceSelectionUp()
    {
        if (ThrowDice1.p1Enabled == true)
        {
           
            if (lastChanceDice < 5)
            {
                ++lastChanceDice;
            }
            int lastChanceDiceVar = lastChanceDice + 1;
            lastChanceDiceSelectionText.text = lastChanceDiceVar.ToString();
        }
    }

    private void DiceSelection()
    {
        if (ThrowDice1.p1Enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (CheckNumberDifferences.diceP1Out[0] == true)
                {
                    
                }
                else
                {
                    mat1[p_currentDice].SetFloat("_LerpVal", 0);
                    p_currentDice = 0;
                    mat1[p_currentDice].SetFloat("_LerpVal", 1);
                }
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (CheckNumberDifferences.diceP1Out[1] == true)
                {

                }
                else
                {
                    mat1[p_currentDice].SetFloat("_LerpVal", 0);
                    p_currentDice = 1;
                    mat1[p_currentDice].SetFloat("_LerpVal", 1);
                }
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (CheckNumberDifferences.diceP1Out[2] == true)
                {

                }
                else
                {
                    mat1[p_currentDice].SetFloat("_LerpVal", 0);
                    p_currentDice = 2;
                    mat1[p_currentDice].SetFloat("_LerpVal", 1);
                }
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (CheckNumberDifferences.diceP1Out[3] == true)
                {

                }
                else
                {
                    mat1[p_currentDice].SetFloat("_LerpVal", 0);
                    p_currentDice = 3;
                    mat1[p_currentDice].SetFloat("_LerpVal", 1);
                }
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (CheckNumberDifferences.diceP1Out[4] == true)
                {

                }
                else
                {
                    mat1[p_currentDice].SetFloat("_LerpVal", 0);
                    p_currentDice = 4;
                    mat1[p_currentDice].SetFloat("_LerpVal", 1);
                }
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                if (CheckNumberDifferences.diceP1Out[5] == true)
                {

                }
                else
                {
                    mat1[p_currentDice].SetFloat("_LerpVal", 0);
                    p_currentDice = 5;
                    mat1[p_currentDice].SetFloat("_LerpVal", 1);
                }
            }
        }
    }

    private void Throw()
    {

        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (p_strenght < strenghtMax)
            {
                ++p_strenght;
            }
        }
    }

    public void endOfTurn()
    {
        for (int i = 0; i < p_numberOfDice; i++)
        {
            mat1[i].SetFloat("_LerpVal", 0);
        }
        DiceResultGenerator.PosFaceP1 = new Vector3(dice[p_currentDice].transform.position.x, dice[p_currentDice].transform.position.y + 0.1f, dice[p_currentDice].transform.position.z);
        DiceRollingManager.currentDiceP1 = p_currentDice;
        DiceRollingManager.strenghtP1 = p_strenght;
        p2Enabled = true;
        ThrowDice1.p1Enabled = false;
        changeLastChanceValUp.SetActive(false);
        changeLastChanceValDown.SetActive(false);
        changeLastChanceDiceUp.SetActive(false);
        changeLastChanceDiceDown.SetActive(false);
        currentLastChanceDice.SetActive(false);
        currentLastChanceVal.SetActive(false);
        DiceRollingManager.Instance.Roll();
    }
}



using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR;


public class ThrowDice : MonoBehaviour
{
    bool lastChanceSelection = false;
    [SerializeField] GameObject camP1, camP2;
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

    [SerializeField] GameObject changeInputLastChanceDice, changeLastChanceNb, currentLastChanceVal, currentLastChanceDice;
    [SerializeField] TextMeshProUGUI lastChanceNbText, lastChanceDiceSelectionText;
    public static int lastChanceNb = 1;
    public static int lastChanceDice = 1;

    string inputDice;
    string inputDiceNb;
    int lastChanceDiceVar;
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
 
        mat1[0].SetFloat("_LerpVal", 2.35f);
    }

    void Update()
    {
        if (CheckNumberDifferences.player1DiceLeft == 1)
        {
            changeInputLastChanceDice.SetActive(true);
            changeLastChanceNb.SetActive(true);
            currentLastChanceDice.SetActive(true);
            currentLastChanceVal.SetActive(true);
        }
        
        DiceSelection();

        ChangeColorOfTheSelectionText();

        Throw();

        int.TryParse(inputDiceNb, out lastChanceNb);
        if (lastChanceNb <= 0)
        {
            lastChanceNb = 1;
        }
        if (lastChanceDice > 20)
        {
            lastChanceNb = 20;
        }
        lastChanceNbText.text = lastChanceNb.ToString();

        int.TryParse(inputDice, out lastChanceDiceVar);
        if (lastChanceDiceVar <= 4)
        {
            lastChanceDice = 0;
        }
        if (lastChanceDiceVar > 4 && lastChanceDiceVar <= 6)
        {
            lastChanceDice = 1;
        }
        if (lastChanceDiceVar <= 8 && lastChanceDiceVar > 6)
        {
            lastChanceDice = 2;
        }
        if (lastChanceDiceVar <= 10 && lastChanceDiceVar > 8)
        {
            lastChanceDice = 3;
        }
        if (lastChanceDiceVar <= 12 && lastChanceDiceVar > 10)
        {
            lastChanceDice = 4;
        }
        if (lastChanceDiceVar <= 20 && lastChanceDiceVar > 12 || lastChanceDiceVar > 20)
        {
            lastChanceDice = 5;
        }
        int lCDice = lastChanceDice + 1;
        lastChanceDiceSelectionText.text = lCDice.ToString();
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


    public void ReadStringInput(string lastChanceDice)
    {
        inputDice = lastChanceDice;
        Debug.Log(lastChanceDice);
    }

    public void ReadStringInputNumber(string lastChanceNumber)
    {
        inputDiceNb = lastChanceNumber;
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
                    mat1[p_currentDice].SetFloat("_LerpVal", 2.35f);
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
                    mat1[p_currentDice].SetFloat("_LerpVal", 2.35f);
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
                    mat1[p_currentDice].SetFloat("_LerpVal", 2.35f);
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
                    mat1[p_currentDice].SetFloat("_LerpVal", 2.35f);
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
                    mat1[p_currentDice].SetFloat("_LerpVal", 2.35f);
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
                    mat1[p_currentDice].SetFloat("_LerpVal", 2.35f);
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



    public void EndOfTurn()
    {
        SetCam();
        for (int i = 0; i < p_numberOfDice; i++)
        {
            mat1[i].SetFloat("_LerpVal", 0);
        }
        p2Enabled = true;
        ThrowDice1.p1Enabled = false;
        DiceRollingManager.currentDiceP1 = p_currentDice;
        DiceRollingManager.strenghtP1 = p_strenght;
        changeInputLastChanceDice.SetActive(false);
        changeLastChanceNb.SetActive(false);
        currentLastChanceDice.SetActive(false);
        currentLastChanceVal.SetActive(false);
        DiceRollingManager.Instance.Roll();
    }

    public void SetCam()
    {
        camP2.SetActive(true);
        camP1.SetActive(false);
    }
}



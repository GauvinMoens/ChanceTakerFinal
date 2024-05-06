using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ThrowDice1 : MonoBehaviour
{
    static public bool p1Enabled = true;

    [SerializeField] GameObject[] dice;
    
    public static float p_strenghtP2;
    [SerializeField] float strenghtMax = 150;

    int p_currentDice = 0;
    int p_numberOfDice = 6;

    [SerializeField] Material[] mat1 = new Material[6];

    Renderer[] rend = new Renderer[6];

    public static Vector3[] startingPositionP2 = new Vector3[6];


    void Start()
    {
        for (int i = 0; i < p_numberOfDice; i++)
        {
            startingPositionP2[i] = new Vector3(dice[i].transform.position.x, dice[i].transform.position.y, dice[i].transform.position.z);
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

        DiceSelection();

        Throw();
    }

    private void DiceSelection()
    {
        if (ThrowDice.p2Enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {

                if (p_currentDice >= 1 && p_currentDice <= p_numberOfDice - 1)
                {
                    if (p_currentDice < p_numberOfDice - 1)
                    {
                        mat1[p_currentDice].SetFloat("_LerpVal", 0);
                        p_currentDice++;
                        mat1[p_currentDice].SetFloat("_LerpVal", 1);
                    }
                    else
                    {
                        mat1[p_numberOfDice - 1].SetFloat("_LerpVal", 0);
                        p_currentDice = 0;
                        mat1[p_currentDice].SetFloat("_LerpVal", 1);
                    }
                }
                else
                {
                    mat1[p_currentDice].SetFloat("_LerpVal", 0);
                    p_currentDice++;
                    mat1[p_currentDice].SetFloat("_LerpVal", 1);
                }
            }
        }
    }

    private void Throw()
    {

        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (p_strenghtP2 < strenghtMax)
            {
                ++p_strenghtP2;
            }
        }

    }
    public void endOfTurn()
    {
        for (int i = 0; i < p_numberOfDice; i++)
        {
            mat1[i].SetFloat("_LerpVal", 0);
        }
        p1Enabled = true;
        ThrowDice.p2Enabled = false;
        DiceRollingManager.currentDiceP2 = p_currentDice;
        DiceRollingManager.strenghtP2 = p_strenghtP2;
        DiceRollingManager.Instance.Roll();
    }
}


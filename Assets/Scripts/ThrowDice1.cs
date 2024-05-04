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
    [SerializeField] Rigidbody[] diceRb;
    public static float p_strenght;
    [SerializeField] float strenghtMax = 150;
    [SerializeField] float strenghtMultiplier = 3;
    [SerializeField] float strenghtRotMultiplier = 5;
    [SerializeField] float strenghtVerticalMultiplier = 4;
    float p_speed = 50;
    int p_currentDice = 0;
    int p_numberOfDice = 6;

    [SerializeField] Material[] mat1 = new Material[6];

    Renderer[] rend = new Renderer[6];
    float[] p_randNegPosX = new float[6];

    public static int diceRolled;


    void Start()
    {
        for (int i = 0; i < p_numberOfDice; i++)
        {
            rend[i] = dice[i].GetComponent<Renderer>();
        }

        diceRb[0].isKinematic = true;
        diceRb[1].isKinematic = true;
        diceRb[2].isKinematic = true;
        diceRb[3].isKinematic = true;
        diceRb[4].isKinematic = true;
        diceRb[5].isKinematic = true;

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
            if (p_strenght < strenghtMax)
            {
                ++p_strenght;
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {

            for (int i = 0; i < p_numberOfDice; i++)
            {
                mat1[i].SetFloat("_LerpVal", 0);
            }

            float randX = Random.Range(0f, 1f);
            float randY = Random.Range(0f, 1f);
            float randZ = Random.Range(0f, 1f);

            for (int n = 0; n < p_numberOfDice; ++n)
            {
                p_randNegPosX[n] = Random.Range(-0.5f, 0.5f);
            }

            if (p_currentDice == 0)
            {
                diceRb[0].isKinematic = false;

                diceRb[0].AddForce(Vector3.up * p_strenght * Time.deltaTime * strenghtVerticalMultiplier, ForceMode.Impulse);
                diceRb[0].AddForce(new Vector3(-1, 0, p_randNegPosX[0]) * Time.deltaTime * strenghtMultiplier * p_speed * 4, ForceMode.Impulse);
                diceRb[0].AddTorque(new Vector3(randX, randY, randZ) * p_strenght * strenghtRotMultiplier, ForceMode.Impulse);
                diceRolled = 0;
                DiceResultGenerator.NumberGen2();
            }
            if (p_currentDice == 1)
            {
                diceRb[p_currentDice].isKinematic = false;

                diceRb[p_currentDice].AddForce(Vector3.up * p_strenght * Time.deltaTime * strenghtVerticalMultiplier, ForceMode.Impulse);
                diceRb[p_currentDice].AddForce(new Vector3(-1, 0, p_randNegPosX[1]) * Time.deltaTime * strenghtMultiplier * p_speed * 4, ForceMode.Impulse);
                diceRb[p_currentDice].AddTorque(new Vector3(randX, randY, randZ) * p_strenght * strenghtRotMultiplier, ForceMode.Impulse);
                diceRolled = p_currentDice;
                DiceResultGenerator.NumberGen2();
            }
            if (p_currentDice == 2)
            {
                diceRb[p_currentDice].isKinematic = false;

                diceRb[p_currentDice].AddForce(Vector3.up * p_strenght * Time.deltaTime * strenghtVerticalMultiplier, ForceMode.Impulse);
                diceRb[p_currentDice].AddForce(new Vector3(-1, 0, p_randNegPosX[2]) * Time.deltaTime * strenghtMultiplier * p_speed * 4, ForceMode.Impulse);
                diceRb[p_currentDice].AddTorque(new Vector3(randX, randY, randZ) * p_strenght * strenghtRotMultiplier, ForceMode.Impulse);
                diceRolled = p_currentDice;
                DiceResultGenerator.NumberGen2();
            }
            if (p_currentDice == 3)
            {
                diceRb[p_currentDice].isKinematic = false;

                diceRb[p_currentDice].AddForce(Vector3.up * p_strenght * Time.deltaTime * strenghtVerticalMultiplier, ForceMode.Impulse);
                diceRb[p_currentDice].AddForce(new Vector3(-1, 0, p_randNegPosX[3]) * Time.deltaTime * strenghtMultiplier * p_speed * 4, ForceMode.Impulse);
                diceRb[p_currentDice].AddTorque(new Vector3(randX, randY, randZ) * p_strenght * strenghtRotMultiplier, ForceMode.Impulse);
                diceRolled = p_currentDice;
                DiceResultGenerator.NumberGen2();
            }
            if (p_currentDice == 4)
            {
                diceRb[p_currentDice].isKinematic = false;

                diceRb[p_currentDice].AddForce(Vector3.up * p_strenght * Time.deltaTime * strenghtVerticalMultiplier, ForceMode.Impulse);
                diceRb[p_currentDice].AddForce(new Vector3(-1, 0, p_randNegPosX[4]) * Time.deltaTime * strenghtMultiplier * p_speed * 4, ForceMode.Impulse);
                diceRb[p_currentDice].AddTorque(new Vector3(randX, randY, randZ) * p_strenght * strenghtRotMultiplier, ForceMode.Impulse);
                diceRolled = p_currentDice;
                DiceResultGenerator.NumberGen2();
            }
            if (p_currentDice == 5)
            {
                diceRb[p_currentDice].isKinematic = false;

                diceRb[5].AddForce(Vector3.up * p_strenght * Time.deltaTime * strenghtVerticalMultiplier, ForceMode.Impulse);
                diceRb[5].AddForce(new Vector3(-1, 0, p_randNegPosX[5]) * Time.deltaTime * strenghtMultiplier * p_speed * 4, ForceMode.Impulse);
                diceRb[5].AddTorque(new Vector3(randX, randY, randZ) * p_strenght * strenghtRotMultiplier, ForceMode.Impulse);
                diceRolled = 5;
                DiceResultGenerator.NumberGen2();
            }
        }
    }
    public void endOfTurn()
    {
        p1Enabled = true;
        ThrowDice.p2Enabled = false;
    }
}


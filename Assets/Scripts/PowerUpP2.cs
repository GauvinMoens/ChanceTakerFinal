using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpP2 : MonoBehaviour
{
    public static PowerUpP2 instance { get; private set; }
    [SerializeField] GameObject[] powerUp;
    [SerializeField] Material[] powerUpMat;
    Renderer[] rend = new Renderer[3];

    int[] random = new int[3];

    public static bool powerUp1Enabled = false;
    public static bool powerUp2Enabled = false;
    public static bool powerUp3Enabled = false;
    public static bool add2Enabled = false;
    public static bool sub2ToP2Enabled = false;
    public static bool advantageEnabled = false;
    public static bool D4PowerUpEnabled = false;
    public static bool D6PowerUpEnabled = false;
    public static bool D8PowerUpEnabled = false;
    public static bool D10PowerUpEnabled = false;
    public static bool D12PowerUpEnabled = false;
    public static bool D20PowerUpEnabled = false;
    public static bool disadvantageEnabled = false;
    public static bool equalizerPowerUpEnabled = false;
    public static bool lowestWinPowerUp = false;

    private Vector3 C1Pos, C2Pos, C3Pos;
    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        for(int i = 0; i < 12; i++)
        {
            powerUpMat[i].SetFloat("_LerpVal", 0f);
        }
        for (int i = 0; i < 3; i++)
        {
            random[i] = Random.Range(0, 11);
            rend[i] = powerUp[i].GetComponent<Renderer>();
            rend[i].sharedMaterial = powerUpMat[random[i]];
        }

        C1Pos = powerUp[0].transform.position;

        C2Pos = powerUp[1].transform.position;

        C3Pos = powerUp[2].transform.position;
    }

    private void Update()
    {

        if (ThrowDice.p2Enabled == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                powerUpMat[random[0]].SetFloat("_LerpVal", -1.1f);
                powerUp[0].transform.position = new Vector3(powerUp[0].transform.position.x - 0.01f, powerUp[0].transform.position.y + 0.005f, powerUp[0].transform.position.z);
                powerUp1Enabled = true;
                if (random[0] == 0)
                {
                    Add2ToP2();
                }
                if (random[0] == 1)
                {
                    Sub2ToP1();
                }
                if (random[0] == 2)
                {
                    AdvantagePowerUp();
                }
                if (random[0] == 3)
                {
                    D4();
                }
                if (random[0] == 4)
                {
                    D6();
                }
                if (random[0] == 5)
                {
                    D8();
                }
                if (random[0] == 6)
                {
                    D10();
                }
                if (random[0] == 7)
                {
                    D12();
                }
                if (random[0] == 8)
                {
                    D20();
                }
                if (random[0] == 9)
                {
                    DisadvantagePowerUp();
                }
                if (random[0] == 10)
                {
                    EqualizerPowerUp();
                }
                if (random[0] == 11)
                {
                    LowestWinPowerUp();
                }
            }
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
            {
                powerUpMat[random[0]].SetFloat("_LerpVal", 0f);
                powerUp[0].transform.position = C1Pos;
                if (random[0] == 0)
                {
                    add2Enabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 1)
                {
                    sub2ToP2Enabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 2)
                {
                    advantageEnabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 3)
                {
                    D4PowerUpEnabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 4)
                {
                    D6PowerUpEnabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 5)
                {
                    D8PowerUpEnabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 6)
                {
                    D10PowerUpEnabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 7)
                {
                    D12PowerUpEnabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 8)
                {
                    D20PowerUpEnabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 9)
                {
                    disadvantageEnabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 10)
                {
                    equalizerPowerUpEnabled = false;
                    powerUp1Enabled = false;
                }
                if (random[0] == 11)
                {
                    lowestWinPowerUp = false;
                    powerUp1Enabled = false;
                }
            }

            if (Input.GetKey(KeyCode.S))
            {
                powerUpMat[random[1]].SetFloat("_LerpVal", -1.1f);
                powerUp[1].transform.position = new Vector3(powerUp[1].transform.position.x - 0.01f, powerUp[1].transform.position.y + 0.005f, powerUp[1].transform.position.z);
                powerUp2Enabled = true;
                if (random[1] == 0)
                {
                    Add2ToP2();
                }
                if (random[1] == 1)
                {
                    Sub2ToP1();
                }
                if (random[1] == 2)
                {
                    AdvantagePowerUp();
                }
                if (random[1] == 3)
                {
                    D4();
                }
                if (random[1] == 4)
                {
                    D6();
                }
                if (random[1] == 5)
                {
                    D8();
                }
                if (random[1] == 6)
                {
                    D10();
                }
                if (random[1] == 7)
                {
                    D12();
                }
                if (random[1] == 8)
                {
                    D20();
                }
                if (random[1] == 9)
                {
                    DisadvantagePowerUp();
                }
                if (random[1] == 10)
                {
                    EqualizerPowerUp();
                }
                if (random[1] == 11)
                {
                    LowestWinPowerUp();
                }
            }
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
            {
                powerUpMat[random[1]].SetFloat("_LerpVal", 0f);
                powerUp[1].transform.position = C2Pos;
                if (random[1] == 0)
                {
                    add2Enabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 1)
                {
                    sub2ToP2Enabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 2)
                {
                    advantageEnabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 3)
                {
                    D4PowerUpEnabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 4)
                {
                    D6PowerUpEnabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 5)
                {
                    D8PowerUpEnabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 6)
                {
                    D10PowerUpEnabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 7)
                {
                    D12PowerUpEnabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 8)
                {
                    D20PowerUpEnabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 9)
                {
                    disadvantageEnabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 10)
                {
                    equalizerPowerUpEnabled = false;
                    powerUp2Enabled = false;
                }
                if (random[1] == 11)
                {
                    lowestWinPowerUp = false;
                    powerUp2Enabled = false;
                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                powerUpMat[random[2]].SetFloat("_LerpVal", -1.1f);
                powerUp[2].transform.position = new Vector3(powerUp[2].transform.position.x - 0.01f, powerUp[2].transform.position.y + 0.005f, powerUp[2].transform.position.z);
                powerUp3Enabled = true;
                if (random[2] == 0)
                {
                    Add2ToP2();
                }
                if (random[2] == 1)
                {
                    Sub2ToP1();
                }
                if (random[2] == 2)
                {
                    AdvantagePowerUp();
                }
                if (random[2] == 3)
                {
                    D4();
                }
                if (random[2] == 4)
                {
                    D6();
                }
                if (random[2] == 5)
                {
                    D8();
                }
                if (random[2] == 6)
                {
                    D10();
                }
                if (random[2] == 7)
                {
                    D12();
                }
                if (random[2] == 8)
                {
                    D20();
                }
                if (random[2] == 9)
                {
                    DisadvantagePowerUp();
                }
                if (random[2] == 10)
                {
                    EqualizerPowerUp();
                }
                if (random[2] == 11)
                {
                    LowestWinPowerUp();
                }
            }
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
            {
                powerUp[2].transform.position = C3Pos;
                powerUpMat[random[2]].SetFloat("_LerpVal", 0f);
                if (random[2] == 0)
                {
                    add2Enabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 1)
                {
                    sub2ToP2Enabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 2)
                {
                    advantageEnabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 3)
                {
                    D4PowerUpEnabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 4)
                {
                    D6PowerUpEnabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 5)
                {
                    D8PowerUpEnabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 6)
                {
                    D10PowerUpEnabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 7)
                {
                    D12PowerUpEnabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 8)
                {
                    D20PowerUpEnabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 9)
                {
                    disadvantageEnabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 10)
                {
                    equalizerPowerUpEnabled = false;
                    powerUp3Enabled = false;
                }
                if (random[2] == 11)
                {
                    lowestWinPowerUp = false;
                    powerUp3Enabled = false;
                }
            }
        }
    }

    public void Add2ToP2()
    {
        add2Enabled = true;
        //add splash screen;
    }

    public void Sub2ToP1()
    {
        sub2ToP2Enabled = true;
        //add splash screen
    }

    public void AdvantagePowerUp()
    {
        advantageEnabled = true;
    }

    public void D4()
    {
        D4PowerUpEnabled = true;
    }

    public void D6()
    {
        D6PowerUpEnabled = true;
    }

    public void D8()
    {
        D8PowerUpEnabled = true;
    }

    public void D10()
    {
        D10PowerUpEnabled = true;
    }
    public void D12()
    {
        D12PowerUpEnabled = true;
    }

    public void D20()
    {
        D20PowerUpEnabled = true;
    }

    public void DisadvantagePowerUp()
    {
        disadvantageEnabled = false;
    }

    public void EqualizerPowerUp()
    {
        equalizerPowerUpEnabled = true;
    }

    public void LowestWinPowerUp()
    {
        lowestWinPowerUp = true;
    }

    public void DisabledPowerUp1()
    {
        powerUp[0].SetActive(false);
    }
    public void DisabledPowerUp2()
    {
        powerUp[1].SetActive(false);
    }
    public void DisabledPowerUp3()
    {
        powerUp[2].SetActive(false);
    }
}

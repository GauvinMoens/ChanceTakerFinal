using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using WebSocketSharp;

public class DiceResultGenerator : MonoBehaviour
{
    public static DiceResultGenerator Instance { get; private set; }

    public static int numberGenerated1, numberGenerated1Bis, numberGeneratedP1Disadvantage;
    public static int numberGenerated2, numberGenerated2Bis, numberGeneratedP2Disadvantage;

    public static Vector3 PosFaceP1 = Vector3.zero;
    public static Vector3 PosFaceP2 = Vector3.zero;

    [SerializeField] GameObject diceFaceP1;
    [SerializeField] GameObject diceFaceP2;

    [SerializeField] Material[] number;

    private Renderer[] rend = new Renderer[2];

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        rend[0] = diceFaceP1.GetComponent<Renderer>();
        rend[1] = diceFaceP2.GetComponent<Renderer>();
    }

    public static void NumberGen1()
    {
        if (PowerUpP1.advantageEnabled == false)
        {
            if (DiceRollingManager.diceRolledP1 == 0)
            {
                numberGenerated1 = Random.Range(1, 4);
                //numberGenerated1 = 1;
            }
            if (DiceRollingManager.diceRolledP1 == 1)
            {
                numberGenerated1 = Random.Range(1, 6);
            }
            if (DiceRollingManager.diceRolledP1 == 2)
            {
                numberGenerated1 = Random.Range(1, 8);
            }
            if (DiceRollingManager.diceRolledP1 == 3)
            {
                numberGenerated1 = Random.Range(1, 10);
            }
            if (DiceRollingManager.diceRolledP1 == 4)
            {
                numberGenerated1 = Random.Range(1, 12);
            }
            if (DiceRollingManager.diceRolledP1 == 5)
            {
                numberGenerated1 = Random.Range(1, 20);
            }

        }
        //equalizer
        if (PowerUpP2.equalizerPowerUpEnabled == true)
        {
            if (DiceRollingManager.diceRolledP2 == 0)
            {
                numberGenerated1 = Random.Range(1, 4);
                //numberGenerated1 = 1;
            }
            if (DiceRollingManager.diceRolledP2 == 1)
            {
                numberGenerated1 = Random.Range(1, 6);
            }
            if (DiceRollingManager.diceRolledP2 == 2)
            {
                numberGenerated1 = Random.Range(1, 8);
            }
            if (DiceRollingManager.diceRolledP2 == 3)
            {
                numberGenerated1 = Random.Range(1, 10);
            }
            if (DiceRollingManager.diceRolledP2 == 4)
            {
                numberGenerated1 = Random.Range(1, 12);
            }
            if (DiceRollingManager.diceRolledP2 == 5)
            {
                numberGenerated1 = Random.Range(1, 20);
            }
            PowerUpP2.equalizerPowerUpEnabled = false;
        }
            //DicePowerUps
        if (PowerUpP1.D4PowerUpEnabled == true)
        {
            numberGenerated1 = Random.Range(1, 4);
            PowerUpP1.D4PowerUpEnabled = false;
        }
        if (PowerUpP1.D6PowerUpEnabled == true)
        {
            numberGenerated1 = Random.Range(1, 6);
            PowerUpP1.D6PowerUpEnabled = false;
        }
        if (PowerUpP1.D8PowerUpEnabled == true)
        {
            numberGenerated1 = Random.Range(1, 8);
            PowerUpP1.D8PowerUpEnabled = false;
        }
        if (PowerUpP1.D10PowerUpEnabled == true)
        {
            numberGenerated1 = Random.Range(1, 10);
            PowerUpP1.D10PowerUpEnabled = false;
        }
        if (PowerUpP1.D12PowerUpEnabled == true)
        {
            numberGenerated1 = Random.Range(1, 12);
            PowerUpP1.D12PowerUpEnabled = false;
        }
        if (PowerUpP1.D20PowerUpEnabled == true)
        {
            numberGenerated1 = Random.Range(1, 20);
            PowerUpP1.D20PowerUpEnabled = false;
        }

        if (PowerUpP2.disadvantageEnabled == true)
        {

            if (DiceRollingManager.diceRolledP1 == 0)
            {
                numberGenerated1 = Random.Range(1, 4);
                numberGeneratedP1Disadvantage = Random.Range(1, 4);
            }
            if (DiceRollingManager.diceRolledP2 == 1)
            {
                numberGenerated1 = Random.Range(1, 6);
                numberGeneratedP1Disadvantage = Random.Range(1, 6);
            }
            if (DiceRollingManager.diceRolledP2 == 2)
            {
                numberGenerated1 = Random.Range(1, 8);
                numberGeneratedP1Disadvantage = Random.Range(1, 8);
            }
            if (DiceRollingManager.diceRolledP2 == 3)
            {
                numberGenerated1 = Random.Range(1, 10);
                numberGeneratedP1Disadvantage = Random.Range(1, 10);
            }
            if (DiceRollingManager.diceRolledP2 == 4)
            {
                numberGenerated1 = Random.Range(1, 12);
                numberGeneratedP1Disadvantage = Random.Range(1, 12);
            }
            if (DiceRollingManager.diceRolledP2 == 5)
            {
                numberGenerated1 = Random.Range(1, 20);
                numberGeneratedP1Disadvantage = Random.Range(1, 20);
            }

            if (numberGeneratedP1Disadvantage <= numberGenerated1)
            {
                numberGenerated1 = numberGeneratedP1Disadvantage;
            }
            PowerUpP2.disadvantageEnabled = false;
        }

        if (PowerUpP1.advantageEnabled == true)
        {
            if (DiceRollingManager.diceRolledP1 == 0)
            {
                numberGenerated1 = Random.Range(1, 4);
                numberGenerated1Bis = Random.Range(1, 4);
            }
            if (DiceRollingManager.diceRolledP1 == 1)
            {
                numberGenerated1 = Random.Range(1, 6);
                numberGenerated1Bis = Random.Range(1, 6);
            }
            if (DiceRollingManager.diceRolledP1 == 2)
            {
                numberGenerated1 = Random.Range(1, 8);
                numberGenerated1Bis = Random.Range(1, 8);
            }
            if (DiceRollingManager.diceRolledP1 == 3)
            {
                numberGenerated1 = Random.Range(1, 10);
                numberGenerated1Bis = Random.Range(1, 10);
            }
            if (DiceRollingManager.diceRolledP1 == 4)
            {
                numberGenerated1 = Random.Range(1, 12);
                numberGenerated1Bis = Random.Range(1, 12);
            }
            if (DiceRollingManager.diceRolledP1 == 5)
            {
                numberGenerated1 = Random.Range(1, 20);
                numberGenerated1Bis = Random.Range(1, 20);
            }
            
            if(numberGenerated1 <= numberGenerated1Bis)
            {
                numberGenerated1 = numberGenerated1Bis;
            }
            PowerUpP1.advantageEnabled = false;
        }


        //powerUps
        if(PowerUpP1.add2Enabled == true)
        {
            numberGenerated1 += 2;
            if(numberGenerated1 > 20)
            {
                numberGenerated1 = 20;
            }
            PowerUpP1.add2Enabled = false;
        }

        if (PowerUpP2.sub2ToP2Enabled == true)
        {
            numberGenerated1 -= 2;
            if (numberGenerated1 <- 0)
            {
                numberGenerated1 = 0;
            }
            PowerUpP2.sub2ToP2Enabled = false;
        }


        //Disabled used powerUp
        if (PowerUpP1.powerUp1Enabled == true)
        {
            PowerUpP1.instance.DisabledPowerUp1();
        }
        if (PowerUpP1.powerUp2Enabled == true)
        {
            PowerUpP1.instance.DisabledPowerUp2();
        }
        if (PowerUpP1.powerUp3Enabled == true)
        {
            PowerUpP1.instance.DisabledPowerUp3();
        }
    }
    public static void NumberGen2()
    {
        if (DiceRollingManager.diceRolledP2 == 0)
        {
            numberGenerated2 = Random.Range(1, 4);
        }
        if (DiceRollingManager.diceRolledP2 == 1)
        {
            numberGenerated2 = Random.Range(1, 6);
        }
        if (DiceRollingManager.diceRolledP2 == 2)
        {
            numberGenerated2 = Random.Range(1, 8);
        }
        if (DiceRollingManager.diceRolledP2 == 3)
        {
            numberGenerated2 = Random.Range(1, 10);
        }
        if (DiceRollingManager.diceRolledP2 == 4)
        {
            numberGenerated2 = Random.Range(1, 12);
        }
        if (DiceRollingManager.diceRolledP2 == 5)
        {
            numberGenerated2 = Random.Range(1, 20);
        }

        //equalizer
        if(PowerUpP1.equalizerPowerUpEnabled == true)
        {
            if (DiceRollingManager.diceRolledP1 == 0)
            {
                numberGenerated2 = Random.Range(1, 4);
            }
            if (DiceRollingManager.diceRolledP1 == 1)
            {
                numberGenerated2 = Random.Range(1, 6);
            }
            if (DiceRollingManager.diceRolledP1 == 2)
            {
                numberGenerated2 = Random.Range(1, 8);
            }
            if (DiceRollingManager.diceRolledP1 == 3)
            {
                numberGenerated2 = Random.Range(1, 10);
            }
            if (DiceRollingManager.diceRolledP1 == 4)
            {
                numberGenerated2 = Random.Range(1, 12);
            }
            if (DiceRollingManager.diceRolledP1 == 5)
            {
                numberGenerated2 = Random.Range(1, 20);
            }
            PowerUpP1.equalizerPowerUpEnabled = false;
        }

        if (PowerUpP1.disadvantageEnabled == true)
        {

            if (DiceRollingManager.diceRolledP2 == 0)
            {
                numberGenerated2 = Random.Range(1, 4);
                numberGeneratedP2Disadvantage = Random.Range(1, 4);
            }
            if (DiceRollingManager.diceRolledP2 == 1)
            {
                numberGenerated2 = Random.Range(1, 6);
                numberGeneratedP2Disadvantage = Random.Range(1, 6);
            }
            if (DiceRollingManager.diceRolledP2 == 2)
            {
                numberGenerated2 = Random.Range(1, 8);
                numberGeneratedP2Disadvantage = Random.Range(1, 8);
            }
            if (DiceRollingManager.diceRolledP2 == 3)
            {
                numberGenerated2 = Random.Range(1, 10);
                numberGeneratedP2Disadvantage = Random.Range(1, 10);
            }
            if (DiceRollingManager.diceRolledP2 == 4)
            {
                numberGenerated2 = Random.Range(1, 12);
                numberGeneratedP2Disadvantage = Random.Range(1, 12);
            }
            if (DiceRollingManager.diceRolledP2 == 5)
            {
                numberGenerated2 = Random.Range(1, 20);
                numberGeneratedP2Disadvantage = Random.Range(1, 20);
            }

            if(numberGeneratedP2Disadvantage <= numberGenerated2)
            {
                numberGenerated2 = numberGeneratedP2Disadvantage;
            }
            PowerUpP1.disadvantageEnabled = false;
        }

        if (PowerUpP2.advantageEnabled == true)
        {
            if (DiceRollingManager.diceRolledP2 == 0)
            {
                numberGenerated2 = Random.Range(1, 4);
                numberGenerated2Bis = Random.Range(1, 4);
            }
            if (DiceRollingManager.diceRolledP2 == 1)
            {
                numberGenerated2 = Random.Range(1, 6);
                numberGenerated2Bis = Random.Range(1, 6);
            }
            if (DiceRollingManager.diceRolledP2 == 2)
            {
                numberGenerated2 = Random.Range(1, 8);
                numberGenerated2Bis = Random.Range(1, 8);
            }
            if (DiceRollingManager.diceRolledP2 == 3)
            {
                numberGenerated2 = Random.Range(1, 10);
                numberGenerated2Bis = Random.Range(1, 10);
            }
            if (DiceRollingManager.diceRolledP2 == 4)
            {
                numberGenerated2 = Random.Range(1, 12);
                numberGenerated2Bis = Random.Range(1, 12);
            }
            if (DiceRollingManager.diceRolledP2 == 5)
            {
                numberGenerated2 = Random.Range(1, 20);
                numberGenerated2Bis = Random.Range(1, 20);
            }

            if (numberGenerated2 <= numberGenerated2Bis)
            {
                numberGenerated2 = numberGenerated2Bis;
            }
            PowerUpP1.advantageEnabled = false;
        }


        //DicePowerUps
        if (PowerUpP2.D4PowerUpEnabled == true)
        {
            numberGenerated2 = Random.Range(1, 4);
            PowerUpP2.D4PowerUpEnabled = false;
        }
        if (PowerUpP2.D6PowerUpEnabled == true)
        {
            numberGenerated2 = Random.Range(1, 6);
            PowerUpP2.D6PowerUpEnabled = false;
        }
        if (PowerUpP2.D8PowerUpEnabled == true)
        {
            numberGenerated2 = Random.Range(1, 8);
            PowerUpP2.D8PowerUpEnabled = false;
        }
        if (PowerUpP2.D10PowerUpEnabled == true)
        {
            numberGenerated2 = Random.Range(1, 10);
            PowerUpP2.D10PowerUpEnabled = false;
        }
        if (PowerUpP2.D12PowerUpEnabled == true)
        {
            numberGenerated2 = Random.Range(1, 12);
            PowerUpP2.D12PowerUpEnabled = false;
        }
        if (PowerUpP2.D20PowerUpEnabled == true)
        {
            numberGenerated2 = Random.Range(1, 20);
            PowerUpP2.D20PowerUpEnabled = false;
        }

        //powerUps
        if (PowerUpP2.add2Enabled == true)
        {
            numberGenerated2 += 2;
            if (numberGenerated2 > 20)
            {
                numberGenerated2 = 20;
            }
            PowerUpP2.add2Enabled = false;
        }

        if (PowerUpP1.sub2ToP2Enabled == true)
        {
            numberGenerated2 -= 2;
            if (numberGenerated2 <= 0)
            {
                numberGenerated2 = 1;
            }
            PowerUpP1.sub2ToP2Enabled = false;
        }

        //Disabled used powerUp
        if (PowerUpP2.powerUp1Enabled == true)
        {
            PowerUpP2.instance.DisabledPowerUp1();
        }
        if (PowerUpP2.powerUp2Enabled == true)
        {           
            PowerUpP2.instance.DisabledPowerUp2();
        }           
        if (PowerUpP2.powerUp3Enabled == true)
        {           
            PowerUpP2.instance.DisabledPowerUp3();
        }           
    }

    public static void NumberGenInEqualCaseP1()
    {
        numberGenerated1 = Random.Range(1, 6);
    }
    public static void NumberGenInEqualCaseP2()
    {
        numberGenerated2 = Random.Range(1, 6);
    }

    public static float time;
    public static bool show = false;
    private void Update()
    {
        time += Time.deltaTime;
    }

    public void ShowNumberOfTheDice()
    {
        Invoke("InstantiateNumber", 2);
    }

    public void InstantiateNumber()
    {
        rend[0].sharedMaterial = number[numberGenerated1 - 1];
        rend[1].sharedMaterial = number[numberGenerated2 - 1];
        GameObject P1 = Instantiate(diceFaceP1, PosFaceP1, Quaternion.Euler(0,180,0));
        GameObject P2 = Instantiate(diceFaceP2, PosFaceP2, Quaternion.Euler(0, 180, 0));
        Destroy(P1, 2);
        Destroy(P2, 2);
    }
}

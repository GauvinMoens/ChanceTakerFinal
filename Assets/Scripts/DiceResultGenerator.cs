using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using WebSocketSharp;

public class DiceResultGenerator : MonoBehaviour
{
    public static DiceResultGenerator Instance { get; private set; }

    public static int numberGenerated1;
    public static int numberGenerated2;

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
        if(DiceRollingManager.diceRolledP1 == 0)
        {
            numberGenerated1 = Random.Range(1,4);
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
            numberGenerated2 = Random.Range(1, 12);
        }
        if (DiceRollingManager.diceRolledP1 == 4)
        {
            numberGenerated1 = Random.Range(1, 12);
        }
        if (DiceRollingManager.diceRolledP1 == 5)
        {
            numberGenerated1 = Random.Range(1, 20);
        }
        Debug.Log(DiceRollingManager.diceRolledP1 + " " + numberGenerated1);
    }
    public static void NumberGen2()
    {
        if (DiceRollingManager.diceRolledP2 == 0)
        {
            numberGenerated2 = Random.Range(1, 4);
            //numberGenerated2 = 1;
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
            numberGenerated2 = Random.Range(1, 12);
        }
        if (DiceRollingManager.diceRolledP2 == 4)
        {
            numberGenerated2 = Random.Range(1, 12);
        }
        if (DiceRollingManager.diceRolledP2 == 5)
        {
            numberGenerated2 = Random.Range(1, 20);
        }
        Debug.Log(DiceRollingManager.diceRolledP2 + " " + numberGenerated2);
    }

    public static void numberGenInEqualCaseP1()
    {
        numberGenerated1 = Random.Range(1, 6);
    }
    public static void numberGenInEqualCaseP2()
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
        Debug.Log("numberOfFace");
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

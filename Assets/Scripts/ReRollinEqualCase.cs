using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReRollinEqualCase : MonoBehaviour
{
    public static ReRollinEqualCase Instance { get; private set; }

    [SerializeField] float strenghtMultiplier = 1.4f;
    [SerializeField] float strenghtRotMultiplier = 2;
    [SerializeField] float strenghtVerticalMultiplier = 2;

    [SerializeField] GameObject P1, P2;
    [SerializeField] Rigidbody RbP1, RbP2;

    [SerializeField] GameObject player1, player2;

    float p_randNegPosXP1;
    float p_randNegPosXP2;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        RbP1.isKinematic = false;
        RbP2.isKinematic = false;
        RbP1.isKinematic = false;

    }

    public void ReRollEqualCase()
    {
        P1.SetActive(true);
        P2.SetActive(true);

        float randXP1 = Random.Range(0f, 1f);
        float randYP1 = Random.Range(0f, 1f);
        float randZP1 = Random.Range(0f, 1f);
        p_randNegPosXP1 = Random.Range(-0.5f, 0.5f);
        RbP1.isKinematic = false;
        RbP1.AddForce(Vector3.up * 60 * Time.deltaTime * strenghtVerticalMultiplier, ForceMode.Impulse);
        RbP1.AddForce(new Vector3(-1, 0, p_randNegPosXP1) * Time.deltaTime * strenghtMultiplier * 50 * 4, ForceMode.Impulse);
        RbP1.AddTorque(new Vector3(randXP1, randYP1, randZP1) * DiceRollingManager.strenghtP1 * strenghtRotMultiplier, ForceMode.Impulse);
        DiceResultGenerator.numberGenInEqualCaseP1();

        float randXP2 = Random.Range(0f, 1f);
        float randYP2 = Random.Range(0f, 1f);
        float randZP2 = Random.Range(0f, 1f);
        p_randNegPosXP2 = Random.Range(-0.5f, 0.5f);
        RbP2.isKinematic = false;
        RbP2.AddForce(Vector3.up * 60 * Time.deltaTime * strenghtVerticalMultiplier, ForceMode.Impulse);
        RbP2.AddForce(new Vector3(-1, 0, p_randNegPosXP2) * Time.deltaTime * strenghtMultiplier * 50 * 4, ForceMode.Impulse);
        RbP2.AddTorque(new Vector3(randXP2, randYP2, randZP2) * 60 * strenghtRotMultiplier, ForceMode.Impulse);
        DiceResultGenerator.numberGenInEqualCaseP2();

        CheckNumberDifferences.Instance.CheckDifferenceBetweenResultNumbers();
        player1.SetActive(true);
        player2.SetActive(true);
    }
}

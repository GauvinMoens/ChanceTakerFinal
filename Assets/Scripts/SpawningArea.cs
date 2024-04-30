using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;


public class SpawningArea : NetworkBehaviour
{
    public static NetworkVariable<int> playerNb = new NetworkVariable<int>(0, NetworkVariableReadPermission.Everyone);
    public static int revertThrow;
    public static int switchingMat;

    private void Start()
    {
        SpawnServerRpc();
    }

    [ServerRpc(RequireOwnership = false)]
    private void SpawnServerRpc()
    {
        playerNb.Value = NetworkManager.Singleton.ConnectedClients.Count;
        Debug.Log(playerNb.Value);
        if (playerNb.Value == 1)
        {
            transform.position = new Vector3(-0.46f, 2.8f, 4.25f);
            revertThrow = 1;
            switchingMat = 0;
        }
        else
        {
            transform.position = new Vector3(0, 0.8f, 4);
            revertThrow = -1;
            switchingMat = 1;
        }
    }

    private void Update()
    {
        if (!IsServer) return;
    }
}

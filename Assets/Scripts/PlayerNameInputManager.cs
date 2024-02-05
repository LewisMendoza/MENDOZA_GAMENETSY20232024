using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerNameInputManager : MonoBehaviour
{
    public void SetPlayerName(string playerName)
    {
        if (playerName == null)
        {
            Debug.LogWarning("Player name is empty!");
            return;
        }

        PhotonNetwork.NickName = playerName;
    }
}

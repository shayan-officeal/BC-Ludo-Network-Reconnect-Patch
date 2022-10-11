using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class NetworkReconnect : PunBehaviour, IPunCallbacks
{
    [SerializeField] private GameObject WaitForInternectConnectionToReconnect;
    [SerializeField] private GameObject WaitForOtherPlayerToReconnect;

    public override void OnPhotonPlayerActivityChanged(PhotonPlayer otherPlayer)
    {

        switch (otherPlayer.IsInactive)
        {

            case true:
                WaitForOtherPlayerToReconnect.SetActive(true);
               
                break;
            case false:
                break;
        }
    }
}

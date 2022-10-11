using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitForInternectConnectionToReconnect : MonoBehaviour
{
    [SerializeField] private Text waitingText;
    
    private float timer = 0;

    private void Update() {

        timer += Time.deltaTime;
        waitingText.text = "Waiting For Internet Connection To Reconnect in " + (int)timer + "s";
    }
}

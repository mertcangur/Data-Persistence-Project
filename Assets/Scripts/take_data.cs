using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class take_data : MonoBehaviour
{
    public static string _playerName;


    public void whatIsYourName(string playerNameInput)
    {
        _playerName = playerNameInput;
        var manager = GameObject.FindObjectOfType<dontDestroy>().GetComponent<dontDestroy>();
        manager.playerName = _playerName;
    }

}

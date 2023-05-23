using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    //private static dontDestroy obje = null;
    public string playerName;
    private void Awake()
    {

        DontDestroyOnLoad(gameObject);
    }
}

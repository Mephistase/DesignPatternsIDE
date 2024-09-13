using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public string namy="";
    private void Start()
    {
        Singleton.Instance.playerName = namy;
    }
}

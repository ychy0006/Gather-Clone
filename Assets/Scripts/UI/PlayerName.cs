using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerName : MonoBehaviour
{
    private TMP_Text playerName;
  
    void Start()
    {
        playerName = GetComponent<TMP_Text>();
        playerName.text = PlayerPrefs.GetString("playerName");
    }
}

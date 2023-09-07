using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisplay : MonoBehaviour
{
    public RuntimeAnimatorController[] animators;

    void Start()
    {
        CharacterDisplay();
    }

    void CharacterDisplay()
    {
        if (PlayerPrefs.HasKey("playerChoice"))
        {
            int idx = PlayerPrefs.GetInt("playerChoice");
            PlayerPrefs.DeleteKey("playerChoice");
            GetComponent<Animator>().runtimeAnimatorController = animators[idx];
        }
    }
}

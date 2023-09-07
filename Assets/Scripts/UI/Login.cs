using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Login : MonoBehaviour
{
    public TMP_InputField inputId;

    public GameObject panel;
    public Button ChoiceButton;
    public Sprite[] sprites;

    public void ClickJoinButton()
    {
        string s = inputId.text;
        if (s.Length >= 2 && s.Length <= 10)
        {
            PlayerPrefs.SetString("playerName", s);
            PlayerPrefs.Save();
            SceneManager.LoadScene("MainScene");
        }
    }

    public void ClickChoiceButton()
    {
        panel.SetActive(true);
    }

    public void ChoiceCharacterButton(int playerChoice) //이렇게 매개변수도 인스펙터에서 받을 수 있음
    {
        PlayerPrefs.SetInt("playerChoice", playerChoice);
        ChoiceButton.GetComponent<Image>().sprite = sprites[playerChoice];
        panel.SetActive(false);
    }
}

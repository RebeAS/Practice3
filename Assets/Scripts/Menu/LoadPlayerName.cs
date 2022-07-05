using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPlayerName : MonoBehaviour
{
    public Text PlayerNameText;

    private void Start()
    {
        LoadName();
    }

    public void LoadName()
    {
        PlayerNameText.text = PlayerPrefs.GetString("Name");
    }
}
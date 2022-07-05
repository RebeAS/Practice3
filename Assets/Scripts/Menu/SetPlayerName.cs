using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerName : MonoBehaviour
{
    public InputField Playernamefield;

    public void SetName()
    {
        PlayerPrefs.SetString("Name", Playernamefield.textComponent.text);
    }
}
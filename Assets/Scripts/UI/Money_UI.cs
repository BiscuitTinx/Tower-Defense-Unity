using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Money_UI : MonoBehaviour
{
    public TMP_Text moneyText;

    // Update is called once per frame
    void Update()
    {
        //keeps ':' so it looks the same when the value of money changes
        moneyText.text = " : " + PlayerStats.Money.ToString();
    }
}

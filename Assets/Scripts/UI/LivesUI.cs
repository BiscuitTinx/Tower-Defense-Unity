using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LivesUI : MonoBehaviour
{
    public TMP_Text livesText;

    // Update is called once per frame
    void Update()
    {
        //when the value of the lives changes it keeps ':' so it still looks the same
        livesText.text = " : " + PlayerStats.lives.ToString();
    }
}
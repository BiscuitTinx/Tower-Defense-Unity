using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public static bool GameIsOver;
    public GameObject TextUI;
    public GameObject gameOverUI;
    public TMP_Text roundsText;

    void Start()
    {
        GameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
        {
            return;
        }

        if (PlayerStats.lives <= 0)
        {
            EndGame();
            
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
        roundsText.text = PlayerStats.Rounds.ToString();
        TextUI.SetActive(false);
    }
}

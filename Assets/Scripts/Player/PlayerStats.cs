using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;

    public static int lives;
    public int startLives = 20;

    public static int Rounds;

    void Start()
    {
        Money = startMoney;          //start of game player starts with 400 money
        lives = startLives;          //Start of game the player has 20 lives

        Rounds = 0;
    }
}
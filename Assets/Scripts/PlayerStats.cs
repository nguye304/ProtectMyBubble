using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{

    public static int Money;
    public int startMoney = 400;

   

    public static int Lives;
    public int startLives = 20;

    public static int Kills;
    public int startKills = 20;

    public static int Rounds;

    void Start()
    {
        Money = startMoney;
        Lives = startLives;
        Kills = startKills;
        Rounds = 0;
    }

}
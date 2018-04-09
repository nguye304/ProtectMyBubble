using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public static bool GameIsOver;

    public static bool GameIsWin;

    public GameObject gameOverUI;
    public GameObject gameWinUI;


    void Start()
    {
        
        GameIsOver = false;
        GameIsWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsOver|| GameIsWin)
            return;

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
        if (PlayerStats.Kills <= 0)
        {
            WinGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }

    void WinGame()
    {
        GameIsWin = true;
        gameWinUI.SetActive(true);
    }

}
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinUI_Level1 : MonoBehaviour
{

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main_Menu");
        Debug.Log("Go to menu.");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level_2");
        Debug.Log("Go to Level_2.");
    }

}
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinUI_Level2 : MonoBehaviour
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

    public void Level3()
    {
        SceneManager.LoadScene("Level_3");
        Debug.Log("Go to Level_3.");
    }

}
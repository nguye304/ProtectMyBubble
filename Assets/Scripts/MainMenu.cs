using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public void Play()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Quit()
    {
        Debug.Log("Exciting...");
        Application.Quit();
    }

}
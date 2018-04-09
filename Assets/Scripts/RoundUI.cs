using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RoundUI : MonoBehaviour
{

    public Text roundText;

    // Update is called once per frame
    void Update()
    {
        roundText.text = "#Enemy: " + PlayerStats.Kills.ToString();
    }
}
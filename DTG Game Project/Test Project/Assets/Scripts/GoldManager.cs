using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldManager : MonoBehaviour
{
    public float Gold;
    private float GoldLeft = 10;
    public TextMeshProUGUI goldtext; //variavles for UI
    public void GoldFound()
    {
        Gold = Gold + 1;
        GoldLeft = 10 - Gold;
        goldtext.text = "Gold Remaining - " + GoldLeft; //update the Game Ui
        if (Gold == 10)
        {
            PlayerWon();
        }
    }

    public void PlayerWon()
    {
        SceneManager.LoadScene("WinScene"); //calls win screen
    }
}

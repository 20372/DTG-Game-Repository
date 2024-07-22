using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void restart()
    //all this just makes it so if you press the buttons they will go into the assigned scenes. for example if you press a button assigned with restart you go to Start Scene
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void BackToStart()
    {
        SceneManager.LoadScene("Menu");
    }
}

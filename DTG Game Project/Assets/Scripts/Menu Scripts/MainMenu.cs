using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Factory"); //Loads the Game Scene
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game"); //QUits the Game (only works when running)
        Application.Quit();
    }

    public void MainMenuLoader()
    {
        SceneManager.LoadScene("Menu"); //Loads the Main Menu Scene
    }
}

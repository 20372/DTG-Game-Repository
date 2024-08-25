using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject GameOverUI;

    private void Awake()
    {
        GameOverUI.SetActive(false);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

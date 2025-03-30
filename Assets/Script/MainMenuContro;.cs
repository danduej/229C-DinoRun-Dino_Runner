using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    void StartGame()
    {
        SceneManager.LoadScene("DinoRun");
    }

    void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

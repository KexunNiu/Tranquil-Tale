using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
//when player press this button, resume the game to normal speed and close the pause menu

    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Resume()
    {
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync("PauseMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

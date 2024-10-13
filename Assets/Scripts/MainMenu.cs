using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Levels");        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void MenuScreen()
    {
        SceneManager.LoadScene("MainMenuScreen");
    }
    public void About()
    {
        SceneManager.LoadScene("AboutUs");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //#####################################################################################
    //load scene based on button selected
    public void LoadEasyMode()
    {
        SceneManager.LoadScene("EasyScene");
    }

    public void LoadNormalMode()
    {
        SceneManager.LoadScene("NormalScene");
    }

    public void LoadHardMode()
    {
        SceneManager.LoadScene("HardScene");
    }

    //quit game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}

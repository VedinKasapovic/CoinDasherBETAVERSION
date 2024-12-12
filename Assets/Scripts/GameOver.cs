using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //############################################################################
    //return to main menu method from game over screen and from congradulations screen
    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //quit the game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}

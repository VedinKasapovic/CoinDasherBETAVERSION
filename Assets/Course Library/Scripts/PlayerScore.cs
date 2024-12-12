using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    //####################################################################################
    //create instances for the reference to ui, player score and , score required to win
    public Text scoreText;
    private int score = 0;
    private const int winningScore = 15;
    //#####################################################################################
    private void Start()
    {
        //#######################################################################
        //update the score text when the game is started
        UpdateScoreText();
        //#########################################################################
    }

    public void AddScore(int amount)
    {
        //create a method to add the score to the UI and update it as coins are picked up
        score += amount; //Klevis Helped HERE
        UpdateScoreText();

        //create a method when the score reaches 15, the winner scene shows up
        if (score >= winningScore)
        {
            LoadGamewinnerScreen();
        }
    }

    private void UpdateScoreText()
    {
        //Score: is canvas , + score is the score
        scoreText.text = "Score: " + score;
    }

    private void LoadGamewinnerScreen()
    {
        //load the game winner scene
        SceneManager.LoadScene("Gamewinner");
    }
}
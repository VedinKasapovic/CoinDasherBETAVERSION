 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //==================================================================================================
    //create instance for the speed modifier so it can be tweaekd within the inspector
    [SerializeField]
    private float speed = 40.0f;

    //create variables for all other components of the player controller
    private float horizontalInput;
    private float forwardInput;
    public SpawnManager spawnManager;
    public bool gameOver;
    private Animator playerAnimator;

    void Start()
    {
        //create the playerAnimator function so the animation can be used on the player
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        //get horizontal input from user
        horizontalInput = Input.GetAxis("Horizontal");

        //method to move the player vertially continously with the given speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //method to move the player horizontally left and right
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }


    //method where if the player hits the spawn trigger the new road will be spawned with coins and crates
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnTrigger"))
        {
            spawnManager.SpawnTriggerEntered();
        }
    }

    //method if the player makes contact with a crate, the game over screen would be shown, indicating that the
    //character died
    private void OnCollisionEnter(Collision other)
    {
        //check if player contacted crate
        if (other.gameObject.CompareTag("Crate"))
        {
            gameOver = true;
            Debug.Log("Game Over!");

            //load game over scene
            SceneManager.LoadScene("GameOver");
        }
    }
}
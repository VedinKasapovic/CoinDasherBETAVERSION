using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //=======================================================================================
    //audio implemented by vedin
    //create instance for the score value, and audio pickup sound
    public int scoreValue = 1;
    public AudioClip pickupSound;
    private AudioSource audioSource;

    private void Start()
    {
        //add an audion source component and ensure sound doesn't play at the start
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        //check if player picked up the coin
        if (other.CompareTag("Player"))
        {
            //if the player picked up the coin play the sound effect
            if (pickupSound != null)
            {
                audioSource.PlayOneShot(pickupSound);
            }

            //if the player picked up the coin update the score
            PlayerScore playerScore = other.GetComponent<PlayerScore>();
            if (playerScore != null)
            {
                // add the score to the score value
                playerScore.AddScore(scoreValue);
            }

            //destroy the coin after it's picked up and the sound plays 
            Destroy(gameObject, pickupSound != null ? pickupSound.length : 0f);
        }
    }
}
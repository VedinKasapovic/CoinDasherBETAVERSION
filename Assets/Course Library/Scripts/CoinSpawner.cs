using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //create a reference to coin prefab
    //Vedin helped with the code as its similar to the crate spawner initally taken from challenge 3 random spawns
    public GameObject Coin;

    //create variables for road width, lenght, maximum coins and spawn height
    public float roadWidth = 10f;
    public float roadLength = 50f;
    public int maxCoins = 20;
    public float spawnHeight = 0.5f;

    //position to reset the road
    private Vector3 roadStartPosition;

    private void Start()
    {
        //record initial position of spawner and spawn coins at the start of the game
        roadStartPosition = transform.position;
        SpawnRandomCoins();
    }

    //method to respawn the coins if player crosses the spawn trigger
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            RespawnCoinsWithRoad();
        }
    }

    //spawn random coins method
    private void SpawnRandomCoins()
    {
        if (Coin == null)
        {

            return;
        }

        //spawn the coins randomly across the road method (x + z positions)
        for (int i = 0; i < maxCoins; i++)
        {
            float randomX = Random.Range(-roadWidth / 4, roadWidth / 2);
            float randomZ = Random.Range(roadStartPosition.z, roadStartPosition.z + roadLength);

            Vector3 spawnPosition = new Vector3(randomX, spawnHeight, randomZ);
            Instantiate(Coin, spawnPosition, Quaternion.identity);
        }
    }

    //method to respawn new coins with new road
    private void RespawnCoinsWithRoad()
    {
        //update the roads starting position
        roadStartPosition = transform.position;

        //spawn new coins for new road
        SpawnRandomCoins();
    }
}

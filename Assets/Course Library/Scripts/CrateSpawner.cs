using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    //====================================================================================
    //create a reference to the crate prefab
    public GameObject Crate;

    //crrate variables for the road width, lenght, maximum crartes and spawn height which can be tweaked in
    //the unity inspector
    public float roadWidth = 10f;
    public float roadLength = 50f;
    public int maxCrates = 20;
    public float spawnHeight = 0.5f;

    //create position to reset the road
    private Vector3 roadStartPosition;

    private void Start()
    {
        //when the game begins record initial position of spawner and spawn crates at the start
        roadStartPosition = transform.position;
        SpawnRandomCrates();
    }

    private void OnTriggerEnter(Collider other)
    {
        //method where the player hits the spawn trigger, the crates will be respawned on the new road
        if (other.CompareTag("Player"))
        {
            RespawnCratesWithRoad();
        }
    }

    //method for the random crate spawns
    private void SpawnRandomCrates()
    {
        if (Crate == null)
        {

            return;
        }

        //method for random crate spawns within the road (x + z position)
        for (int i = 0; i < maxCrates; i++)
        {
            float randomX = Random.Range(-roadWidth / 4, roadWidth / 2);
            float randomZ = Random.Range(roadStartPosition.z, roadStartPosition.z + roadLength);

            Vector3 spawnPosition = new Vector3(randomX, spawnHeight, randomZ);
            Instantiate(Crate, spawnPosition, Quaternion.identity);

        }
    }
private void RespawnCratesWithRoad()
    {
        

        //update road start position of new road
        roadStartPosition = transform.position;

        //spawn the crates on the new road
        SpawnRandomCrates();
    }
}
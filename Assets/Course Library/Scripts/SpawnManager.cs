using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;

    //=================================================================================================
    //call the road spawner once the game starts before the player triggers the respawn
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
    }

    void Update()
    {
    }

    //move the road forward
    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
    }
}
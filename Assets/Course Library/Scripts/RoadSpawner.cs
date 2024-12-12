using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{

    public List<GameObject> roads;
    private float offset = 325f;

    //====================================================================================
    //inital road gets spawned before the next
    void Start()
    {
        if (roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    //method to make the road move forward
    //once player triggers the road respawn from the invisible trigger this method will be called
    public void MoveRoad()
    {
        GameObject movedRoad = roads[1];
        roads.Remove(movedRoad);

        float newZ = roads[roads.Count - 1].transform.position.z + offset;
        movedRoad.transform.position = new Vector3(0, 0, newZ);

        roads.Add(movedRoad);
    }
}
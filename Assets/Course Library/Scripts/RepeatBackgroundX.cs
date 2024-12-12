using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==============================================================================================
//Used this code as a method , code is not functional in the actual game
public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatLength;

    private void Start()
    {
        startPos = transform.position;
        repeatLength = GetComponent<BoxCollider>().size.x;
    }

    private void Update()
    {

        if (transform.position.x < startPos.x - repeatLength)
        {
            transform.position = startPos;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //=====================================================================================
    //methods taken from the "Football game" from challange
    //create reference to player object, player offset and create a smoothSpeed variable
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    public float smoothSpeed = 0.125f;

    private void LateUpdate()
    {
        if (player != null)
        {
            //calculate the desired position with the offset
            Vector3 desiredPosition = player.transform.position + offset;
            //smoothly interpolate to the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            //update the camera's position with the smoothed position
            transform.position = smoothedPosition;
        }
    }
}
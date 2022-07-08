using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck : MonoBehaviour
{
    
//Bound Check script to find the bounds of the camera and clamp the playable region to the max width and height of the screen
    // Update is called once per frame
    void Update()
    {
        //If else statement to differentiate between "Hero" Boundaries and "Enemy Boundaries
        //Hero Boundary
        if (gameObject.tag.Equals("Hero"))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -28f, 28f), Mathf.Clamp(transform.position.y, -37f, 37f), transform.position.z);
        }
        //Enemy Boundary
        else
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -28f, 28f), Mathf.Clamp(transform.position.y, -45, 45), transform.position.z);
        }
    }
}

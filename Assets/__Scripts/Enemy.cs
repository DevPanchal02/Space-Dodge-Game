using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Variables Intialized
    public float speed = 10;
    public Rigidbody rb;
 
    //Awake Method
    private void Awake()
    {
        //Gets rigid Body Component
        rb = GetComponent<Rigidbody>();
    }
    //FixedUpdate method to constantly update (Better to use FixedUpdate when using physics)
    private void FixedUpdate()
    {
        //Sets the velocity of the straight moving enemy to y=-10
        rb.velocity = new Vector3(0, -10f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //If statement to check position of gameObjects and to delete gameobjects past a certain height
        //Checks if position is below y = -42
        if (rb.position.y <= -42) 
        {
            //Destroys Enemy gameObject from the hierarchy
            Destroy(rb.gameObject);
        }

    }
}

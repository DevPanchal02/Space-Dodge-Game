using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagEnemy : Enemy
{
    //Zigzag public float variables for positions
    public float x = -10f, y = -10f, z = 0f;
    //FixedUpdate method for physics 
    private void FixedUpdate()
    { 
        //Sets velocity for the zigzag enemies
        rb.velocity = new Vector3(x, y, z);
       
    }

    // Start is called before the first frame update
    void Start()
    {
        //Randomizer to randomize the direction at which the zigzags start
        float multiplier = Random.Range(0, 2) * 2 - 1;
        x = x * multiplier;
    }

    // Update is called once per frame
    void Update()
    {
        //If and else statement to change zigzag direction after a wall is hit
        //Changes direction to -x
        if (rb.transform.position.x >= 28)
        {
            x = -10;
        }
        //Changes direction to +x
        else if (rb.transform.position.x <= -28)
        {
            x = 10;
        }
        //If statement to remove and destroy game objects after a certain height
        if (rb.position.y <= -42)
        {
            //Destroys zigzag enemy Object
            Destroy(rb.gameObject);
        }

    }
}

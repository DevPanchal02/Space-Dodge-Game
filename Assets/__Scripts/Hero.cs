using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour
{
    //Public float variables for Hero character's movement
    public float speed = 30;
    public float pitchMult = 30;
    public float rollMult = -45;

    // Update is called once per frame
    void Update()
    {
        //Pull in the information from the input class
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        //Change transform.position based on the axes
        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;

        //Rotate the ship to make it feel more dynamic
        transform.rotation = Quaternion.Euler(yAxis * pitchMult, xAxis * rollMult, 0);
    }
    //onTriggerEnter Method to check for collisions and to destroy both enemy gameObjects and the player gameObject during a collision
    private void OnTriggerEnter(Collider other)
    {
        //if statement to make sure that the collision is with an enemy
        if (other.gameObject.tag.Equals("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            //Calls Restart to restart the game after player object has been destroyed
            Restart();

        }
    }
  //Restart method to reset the scene
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

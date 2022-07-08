using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    //Game Object variables for both enemy gameObjects
    public GameObject Enemy_1;
    public GameObject Enemy_2;
    //Position Variables for vector
    public int xPos1;
    public int xPos2;
    public int zPos = 0;
    public int yPos = 45;
    //Util Variables
    public int enemyCount = 1;
    public int choice;

    //Start method to run at the start of the game
    private void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    //IEnumerator Method that helps instantiate both enemies and returns with a delay
    IEnumerator EnemyDrop()
    {
        //While loop to constantly spawn in enemies
        while (true)
        {
            //Randomizes spawn x-positions for both enemies
            xPos1 = Random.Range(-25, 25);
            xPos2 = Random.Range(-25, 25);
            //Choice variable to randomize which enemy is chosen
            choice = Random.Range(0, 2) * 2 - 1;
            //if and else statement to determine with enemy is spawned
            if (choice == 1)
            {
                //Instantiates Enemy_1 
                Instantiate(Enemy_1, new Vector3(xPos1, yPos, zPos), Quaternion.identity);
            }
            else if (choice == -1)
            {
                //Instantiates Enemey_2
                Instantiate(Enemy_2, new Vector3(xPos2, yPos, zPos), Quaternion.identity);
            }
            //Yield return for a delay
            yield return new WaitForSeconds(2f);
            enemyCount++;
        }
    }
    //Delated Restart method
    public void DelayedRestart(float delay)
    {
        // Invoke the Restart() method in delay seconds
        Invoke(nameof(Restart), delay);
    }
    //Restart Method
    public void Restart()
    {
        //Reload Scene 0 to restart the game
        SceneManager.LoadScene("__Scene_0");
    }
}

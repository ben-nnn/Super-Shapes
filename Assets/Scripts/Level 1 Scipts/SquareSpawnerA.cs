using System.Collections;
using System.Collections.Generic;
using UnityEngine;




// this code is the same as "Square SpawnerB","Square SpawnerC","PentagonSpawnerA","PentagonSpawnerB","PentagonSpawnerC","HexagonSpawnerA","HexagonSpawnerB","HexagonSpawnerC"

//purpose of this script is to spawn the shape in.



public class SquareSpawnerA : MonoBehaviour
{
    //setting how frequently the shape spawns
    public float spawnRate = 5f;

    //setting the GameObject that will be spawned
    public GameObject SquarePrefab;

    //the amount of time that is between each shape spawned
    private float nextTimeToSpawn;

    //setting how long the gameObject will be spawned in 
    private float maxTime = 30f;


    private void Update()
    {   //while the time on the level is greater then the time to next spawn, and the time since the level loaded is less then the maximum time
        while (Time.timeSinceLevelLoad >= nextTimeToSpawn && Time.timeSinceLevelLoad <= maxTime)
        {
            //create a square prefab, rotate it
            Instantiate(SquarePrefab, Vector3.zero, Quaternion.identity);
            //set time to next spawn to the time since level load + 1f divided by  the spawn rate
            nextTimeToSpawn = Time.timeSinceLevelLoad + 10f / spawnRate;
        }
    }
    
}

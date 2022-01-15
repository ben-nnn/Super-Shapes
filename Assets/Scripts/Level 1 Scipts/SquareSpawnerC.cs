using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SquareSpawnerC : MonoBehaviour
{
    public float spawnRate = 5f;

    public GameObject SquarePrefab;

    private float nextTimeToSpawn = 6f;

    private float maxTime = 60f;


    void Update()
    {
        while (Time.timeSinceLevelLoad >= nextTimeToSpawn && Time.timeSinceLevelLoad <= maxTime)
        {
            Instantiate(SquarePrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.timeSinceLevelLoad + 10f / spawnRate;
        }
    }

}
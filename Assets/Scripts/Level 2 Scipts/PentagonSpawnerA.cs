using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PentagonSpawnerA : MonoBehaviour
{
    public float spawnRate = 5f;

    public GameObject PentagonPrefab;

    private float nextTimeToSpawn = 6f;

    private float maxTime = 30f;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= nextTimeToSpawn && Time.timeSinceLevelLoad <= maxTime)
        {

            Instantiate(PentagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.timeSinceLevelLoad + 10f / spawnRate;
        }
    }
}
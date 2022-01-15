using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HexagonSpawnerC : MonoBehaviour
{
    public float spawnRate = 5f;

    public GameObject HexagonPrefab;

    private float nextTimeToSpawn = 6f;

    private float maxTime = 60f;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= nextTimeToSpawn && Time.timeSinceLevelLoad <= maxTime)
        {

            Instantiate(HexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.timeSinceLevelLoad + 10f / spawnRate;
        }
    }
}
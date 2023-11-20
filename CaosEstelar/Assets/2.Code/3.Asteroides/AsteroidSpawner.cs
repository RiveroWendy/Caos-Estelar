using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRate = 2f;
    public float spawnRadius = 10f;

    void Start()
    {
        InvokeRepeating("SpawnAsteroid", 0f, spawnRate);
    }

    void SpawnAsteroid()
    {
        Vector2 randomPoint = Random.insideUnitCircle * spawnRadius;
        Vector3 spawnPosition = new Vector3(randomPoint.x, randomPoint.y, 0f);

        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }
}

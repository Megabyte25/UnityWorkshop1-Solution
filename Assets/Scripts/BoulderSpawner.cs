using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderSpawner : MonoBehaviour
{
    public float maxSpawnRange;
    public GameObject boulderPrefab;

    private float spawnInterval;
    private float timeSinceLastSpawn;

    void Start()
    {
        // TODO: Obtain relevant information from GameSettings
        var settings = GameObject.FindWithTag("GameSettings")?.GetComponent<GameSettings>();
        spawnInterval = settings.BoulderSpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Spawn boulders with fixed time interval
        // TODO: Randomize the position so that the boulder does not always spawn at the same location
        //       HINT: Use UnityEngine.Random.Range()
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn > spawnInterval)
        {
            Vector3 offset = new Vector3(UnityEngine.Random.Range(-maxSpawnRange, maxSpawnRange), 0, 0);
            GameObject boulder = Instantiate(boulderPrefab, transform.position + offset, Quaternion.identity);
            Destroy(boulder, 10f);
            timeSinceLastSpawn = 0;
        }
    }
}

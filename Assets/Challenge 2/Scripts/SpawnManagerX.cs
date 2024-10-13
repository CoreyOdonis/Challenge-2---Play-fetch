using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22.0f;
    private float spawnLimitXRight = 7.0f;
    private float spawnPosY = 30.0f;

    private float startDelay = 1.0f;

    private float minSpawnInterval = 3.0f;
    private float maxSpawninterval = 5.0f;
 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(minSpawnInterval, maxSpawninterval));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        //Selects ball for spawning
        int randomBall = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[Random.Range(0, 3)], spawnPos, ballPrefabs[Random.Range(0, 3)].transform.rotation);
    }

}

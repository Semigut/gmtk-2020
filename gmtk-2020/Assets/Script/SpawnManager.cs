using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] spawns;
    int randomSpawnPoint;
    int randomSpawn;

    public static bool spawnAllowed; // player alive


    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnEnemy", 0f, 3f);
        

    }

    void SpawnEnemy()
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomSpawn = Random.Range(0, spawns.Length);
            Instantiate(spawns[randomSpawn], spawnPoints[randomSpawnPoint].position, Quaternion.identity);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

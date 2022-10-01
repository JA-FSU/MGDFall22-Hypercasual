using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnerPrefabs;
    public float[] spawnLocations;
    private GameManager gameManager;
    private float startDelay = 2;
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("SpawnRandom", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandom()
    {
        int spawnerIndex = Random.Range(0, spawnerPrefabs.Length);
        int random = Random.Range(0, spawnLocations.Length);
        float randomChoose = spawnLocations[random];
        Vector3 locationIndex = new Vector3(randomChoose, 2.53f, 300.0f);
        
        if (gameManager.isGameActive && !gameManager.isPaused)
        {
            Instantiate(spawnerPrefabs[spawnerIndex], locationIndex, spawnerPrefabs[spawnerIndex].transform.rotation);
        }
    }
}
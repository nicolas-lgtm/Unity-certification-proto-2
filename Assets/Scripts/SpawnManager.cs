using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrebabs;
    float spawnRangeX = 20f;
    float spawnPosZ = 20f;
    float startDelay = 2f;
    float spawnInterval = 1.5f;
    DestroyOutOfBounds destroyScript;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        destroyScript = GameObject.Find("Game Manager").GetComponent<DestroyOutOfBounds>();
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.gameIsActive) CancelInvoke("SpawnRandomAnimals");
    }
    void SpawnRandomAnimals()
    {
            int animalIndex = Random.Range(0, animalPrebabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(animalPrebabs[animalIndex], spawnPos, animalPrebabs[animalIndex].transform.rotation);
        
    }
}

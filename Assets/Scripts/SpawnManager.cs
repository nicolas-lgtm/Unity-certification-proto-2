using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrebabs;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimals();
        }
    }
    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrebabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrebabs[animalIndex], spawnPos, animalPrebabs[animalIndex].transform.rotation);
    }
}

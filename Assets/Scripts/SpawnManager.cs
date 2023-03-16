using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    public float sideSpawnMinz;
    public float sideSpawnMaxz;
    public float sideSpawnx;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPOS = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPOS, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnLeftAniamal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPOS = new Vector3(-sideSpawnx, 0, Random.Range(sideSpawnMinz, sideSpawnMaxz));
        Vector3 rotation = new Vector3(0, 90, 0);
        
        Instantiate(animalPrefabs[animalIndex], spawnPOS, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPOS = new Vector3(sideSpawnx, 0, Random.Range(sideSpawnMinz, sideSpawnMaxz));
        Vector3 rotation = new Vector3(0, -90, 0);

        Instantiate(animalPrefabs[animalIndex], spawnPOS, Quaternion.Euler(rotation));
    }
}

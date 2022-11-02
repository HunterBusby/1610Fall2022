using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //array to store UFO ships
    private float spawnRangex = 20f;
    private float spawnPosZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangex,spawnRangex),0,spawnPosZ);
        int ufoIndex = Random.Range(0,ufoPrefabs.Length); //picks a random UFO from the array
    
        Instantiate(ufoPrefabs[ufoIndex],spawnPOs, ufoPrefabs[ufoIndex].transform.rotation); //spawns indexed UFO from the array
    }
}

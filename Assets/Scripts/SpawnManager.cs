﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemywave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnEnemywave()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }


    private Vector3 GenerateSpawnPosition()
    {
        float spawnPoX = Random.Range(-spawnRange, spawnRange);
        float spawnPoZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPoX, 0, spawnPoZ);

        return randomPos;
    }
}

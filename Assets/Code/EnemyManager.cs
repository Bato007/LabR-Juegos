using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] prefabs;
    public float spawnTime;
    public float spawnDelay;
    public bool stopSpawn = false;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        index = (index == 4) ? 0 : index;

        Instantiate(prefabs[index], gameObject.transform.position, Quaternion.identity);
        Time.timeScale += 0.1f;
        if (stopSpawn == true)
        {
            CancelInvoke("SpawnObject");
        }
    }
}

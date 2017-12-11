using System;
using UnityEngine;

[Serializable]
public class SpawnableObject
{
    private static System.Random randon = new System.Random(DateTime.Now.Second);

    const int MAX_TIME = 6;
    const int MIN_TIME = 2;

    private double spawnTime;
    private double lastSpawnTime;

    public GameObject objectToSpawn;

    public SpawnableObject()
    {
        spawnTime = randon.NextDouble() * 2;
    }

    public bool SpawnNewObject(float time)
    {
        lastSpawnTime += time;
        if (lastSpawnTime >= spawnTime)
        {
            lastSpawnTime = 0;
            spawnTime = randon.NextDouble() * (MAX_TIME - MIN_TIME) + MIN_TIME;
            return true;
        }

        return false;
    }
}

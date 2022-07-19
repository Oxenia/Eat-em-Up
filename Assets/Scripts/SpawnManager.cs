using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public string movementDirection;

    [SerializeField] private GameObject[] allPoints;

    [SerializeField] private float ySpawn;

    [SerializeField] private float zLeftRightSpawnRange;
    [SerializeField] private float xLeftRightSpawn;

    [SerializeField] private float xTopButtomSpawnRange;
    [SerializeField] private float zTopButtomSpawn;

    [SerializeField] private float spawnTime;
    [SerializeField] private float spawnRate;

    private void Start()
    {
        movementDirection = "left";
        InvokeRepeating("SpawnOnDirection", spawnTime, spawnRate);
    }

    public void SpawnOnDirection()
    {
        if (movementDirection == "left")
        {
            RandomSpawnFromRight();
        }
        if (movementDirection == "right")
        {
            RandomSpawnFromLeft();
        }
        if (movementDirection == "forward")
        {
            RandomSpawnFromBottom();
        }
        if (movementDirection == "back")
        {
            RandomSpawnFromTop();
        }
    }

    private void RandomSpawnFromRight()
    {
        float randomZ = Random.Range(zLeftRightSpawnRange, -zLeftRightSpawnRange);
        Vector3 randomPos = new Vector3(xLeftRightSpawn, ySpawn, randomZ);
        int randomIndex = Random.Range(0, allPoints.Length);
        Instantiate(allPoints[randomIndex], randomPos, allPoints[randomIndex].gameObject.transform.rotation);
    }

    private void RandomSpawnFromLeft()
    {
        float randomZ = Random.Range(zLeftRightSpawnRange, -zLeftRightSpawnRange);
        Vector3 randomPos = new Vector3(-xLeftRightSpawn, ySpawn, randomZ);
        int randomIndex = Random.Range(0, allPoints.Length);
        Instantiate(allPoints[randomIndex], randomPos, allPoints[randomIndex].gameObject.transform.rotation);
    }

    private void RandomSpawnFromTop()
    {
        float randomX = Random.Range(xTopButtomSpawnRange, -xTopButtomSpawnRange);
        Vector3 randomPos = new Vector3(randomX, ySpawn, zTopButtomSpawn);
        int randomIndex = Random.Range(0, allPoints.Length);
        Instantiate(allPoints[randomIndex], randomPos, allPoints[randomIndex].gameObject.transform.rotation);
    }

    private void RandomSpawnFromBottom()
    {
        float randomX = Random.Range(xTopButtomSpawnRange, -xTopButtomSpawnRange);
        Vector3 randomPos = new Vector3(randomX, ySpawn, -zTopButtomSpawn);
        int randomIndex = Random.Range(0, allPoints.Length);
        Instantiate(allPoints[randomIndex], randomPos, allPoints[randomIndex].gameObject.transform.rotation);
    }
}

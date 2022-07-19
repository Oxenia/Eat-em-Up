using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public string movementDirection;

    [SerializeField] private GameObject[] allPoints; // ENCAPSULATION

    [SerializeField] private float ySpawn; // ENCAPSULATION

    [SerializeField] private float zLeftRightSpawnRange; // ENCAPSULATION
    [SerializeField] private float xLeftRightSpawn; // ENCAPSULATION

    [SerializeField] private float xTopButtomSpawnRange; // ENCAPSULATION
    [SerializeField] private float zTopButtomSpawn; // ENCAPSULATION

    [SerializeField] private float spawnTime; // ENCAPSULATION
    [SerializeField] private float spawnRate; // ENCAPSULATION

    private void Start()
    {
        movementDirection = "left";
        InvokeRepeating("SpawnOnDirection", spawnTime, spawnRate);
    }

    public void SpawnOnDirection() // ABSTRACTION
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

    private void RandomSpawnFromRight() // ABSTRACTION
    {
        float randomZ = Random.Range(zLeftRightSpawnRange, -zLeftRightSpawnRange);
        Vector3 randomPos = new Vector3(xLeftRightSpawn, ySpawn, randomZ);
        int randomIndex = Random.Range(0, allPoints.Length);
        Instantiate(allPoints[randomIndex], randomPos, allPoints[randomIndex].gameObject.transform.rotation);
    }

    private void RandomSpawnFromLeft() // ABSTRACTION
    {
        float randomZ = Random.Range(zLeftRightSpawnRange, -zLeftRightSpawnRange);
        Vector3 randomPos = new Vector3(-xLeftRightSpawn, ySpawn, randomZ);
        int randomIndex = Random.Range(0, allPoints.Length);
        Instantiate(allPoints[randomIndex], randomPos, allPoints[randomIndex].gameObject.transform.rotation);
    }

    private void RandomSpawnFromTop() // ABSTRACTION
    {
        float randomX = Random.Range(xTopButtomSpawnRange, -xTopButtomSpawnRange);
        Vector3 randomPos = new Vector3(randomX, ySpawn, zTopButtomSpawn);
        int randomIndex = Random.Range(0, allPoints.Length);
        Instantiate(allPoints[randomIndex], randomPos, allPoints[randomIndex].gameObject.transform.rotation);
    }

    private void RandomSpawnFromBottom() // ABSTRACTION
    {
        float randomX = Random.Range(xTopButtomSpawnRange, -xTopButtomSpawnRange);
        Vector3 randomPos = new Vector3(randomX, ySpawn, -zTopButtomSpawn);
        int randomIndex = Random.Range(0, allPoints.Length);
        Instantiate(allPoints[randomIndex], randomPos, allPoints[randomIndex].gameObject.transform.rotation);
    }
}

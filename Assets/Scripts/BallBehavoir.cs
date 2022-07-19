using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavoir : MonoBehaviour
{
    [SerializeField] private float ballSpeed; // ENCAPSULATION
    private float zBoundRange = 70; // ENCAPSULATION
    private float xBoundRange = 135; // ENCAPSULATION
    private Rigidbody ballRB; // ENCAPSULATION
    public SpawnManager spawnMangerScript;

    public void Start()
    {
        ballRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        spawnMangerScript = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();

        SelectDirection(spawnMangerScript.movementDirection);
        DestroyOutOfBounds();
    }

    public void SelectDirection(string direction) // ABSTRACTION
    {
        if (direction == "left")
        {
            ballRB.AddForce(Vector3.left * ballSpeed);
        }
        if (direction == "right")
        {
            ballRB.AddForce(Vector3.right * ballSpeed);
        }
        if (direction == "forward")
        {
            ballRB.AddForce(Vector3.forward * ballSpeed);
        }
        if (direction == "back")
        {
            ballRB.AddForce(Vector3.back * ballSpeed);
        }
    }

    public void DestroyOutOfBounds() // ABSTRACTION
    {
        if (transform.position.x > xBoundRange || transform.position.x < -xBoundRange || transform.position.z > zBoundRange || transform.position.z < -zBoundRange )
        {
            Destroy(gameObject);
        }
    }

    public virtual void SpecialAbility()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SpecialAbility();
        }
    }
}

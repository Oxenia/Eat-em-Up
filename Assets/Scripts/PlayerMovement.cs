using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed;

    private float horizontalInput;
    private float verticalInput;

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * playerSpeed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * playerSpeed * verticalInput * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform playerTransform;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpForce;

    void Awake()
    {
        playerTransform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float xAxis = Input.GetAxis("Vertical");
        float zAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Jump");
        Vector3 movePlayer = new Vector3(xAxis * movementSpeed * Time.fixedDeltaTime, yAxis * jumpForce * Time.fixedDeltaTime, zAxis * movementSpeed * Time.fixedDeltaTime);
    }
}
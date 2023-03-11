using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementOld : MonoBehaviour
{
    private Rigidbody _rb;

    public float moveSpeed;

    public float jumpSpeed;
    private float _X;
    private float _Z;
    public bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        _X = Input.GetAxis("Horizontal");
        _Z = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(_X, 0, _Z) * (Time.deltaTime * moveSpeed);
        _rb.MovePosition(transform.position + transform.TransformDirection(move));
        if (Input.GetKeyUp(KeyCode.Space) && !isGrounded)
        {
            _rb.velocity = Vector3.up * (jumpSpeed * Time.deltaTime);
            
        }
    }
    
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform playerPos;
    public float speed;
    //private int head = 3;

 
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void Update()
    {
        
        //transform.position = Vector2.MoveTowards(transform.position,playerPos.position,speed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

    }
}

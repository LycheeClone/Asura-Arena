using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float cameraFollowSpeed;

    void Start()
    {
        playerTransform = GetComponent<CameraController>().playerTransform;
        cameraTransform = GetComponent<Transform>();
    }

    private void CalculateDistanceFromObject()
    {
        //Vector3 distance = 
    }
}
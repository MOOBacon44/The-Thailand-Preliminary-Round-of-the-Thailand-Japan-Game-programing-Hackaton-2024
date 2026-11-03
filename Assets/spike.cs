using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    

    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;

    [SerializeField] private float speed = 5f;

    private Transform targetPoint;
    [SerializeField] private Transform respawnPoint;
    bool isExit = false;

    private void Start()
    {
        
        targetPoint = pointB;
        
        
        if (pointA != null)
        {
            transform.position = pointA.position;
        }
    }

    private void Update()
    {
        if (pointA == null || pointB == null) return;

  
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
  
        if (transform.position == targetPoint.position)
        {
    
            targetPoint = (targetPoint == pointB) ? pointA : pointB;
        }


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isExit)
        {
            other.gameObject.SetActive(false);
            other.gameObject.transform.position = new Vector3(respawnPoint.position.x, respawnPoint.position.y, respawnPoint.position.z);
            isExit = true;
            other.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isExit = false;
        }
    }
}


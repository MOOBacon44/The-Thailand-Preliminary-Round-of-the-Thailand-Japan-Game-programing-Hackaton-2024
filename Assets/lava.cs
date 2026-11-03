using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    bool isExit = false;
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

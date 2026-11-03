using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noti : MonoBehaviour
{
    public GameObject text;
     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                text.SetActive(false);
        }
    }
}

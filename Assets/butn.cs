using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butn : MonoBehaviour
{
    bool isExit = false;
    public GameObject path;
    public GameObject text;
    void Start(){
        path.SetActive(false);
        text.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                path.SetActive(true);
                print("Button Pressed");
                text.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(true);
            path.SetActive(false);
            IEnumerator r()
            {
                
                yield return new WaitForSeconds(3f);
                text.SetActive(false);
                
            }
            
        }
    }
}


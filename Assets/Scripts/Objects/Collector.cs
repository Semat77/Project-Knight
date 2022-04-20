using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0f;
    bool hasCube;

    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other) {
        if(other.tag == "Cube" && !hasCube){
            Debug.Log("Pick");
            hasCube = true;
            Destroy(other.gameObject, destroyDelay);
        }

        if(other.tag == "DeliveryZone" && hasCube){
            Debug.Log("Delivered");
            hasCube = false;
        }
    }
}

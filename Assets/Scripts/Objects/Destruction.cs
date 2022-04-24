using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    [SerializeField] GameObject block;
    void Update()
    {
        if(Collector.theScore == 4){
            Destroy(block);
        }
    }

}

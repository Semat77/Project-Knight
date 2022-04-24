using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject prefab;

    void Awake() {
        BoxCollider box = prefab.AddComponent<BoxCollider>();     
    }
}

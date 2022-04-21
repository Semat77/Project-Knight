using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTouch : MonoBehaviour
{
    public void OnTriggerEnter(Collider other) {
        if(other.tag == "Skeleton"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

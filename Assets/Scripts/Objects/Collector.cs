using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collector : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0f;
    bool hasCube;
    public GameObject scoreText;
    public static int theScore;


    void Start()
    {
        
    }

    void Update(){
        scoreText.GetComponent<Text>().text = "Score: " + theScore;
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
            theScore += 1;
        }

        if(theScore == 4){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            theScore = 0;
        }
    }
}

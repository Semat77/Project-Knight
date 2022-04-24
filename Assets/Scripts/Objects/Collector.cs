using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collector : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
    public static bool hasSphere;
    private bool hasCube;
    private int skeletonDestroyCounter = 1;
    

    void Update(){
        scoreText.GetComponent<Text>().text = "Score: " + theScore ;
    }

    public void OnTriggerEnter(Collider other) {
        if(other.tag == "Cube" && !hasCube){
            hasCube = true;
            Destroy(other.gameObject);
        }

        if(other.tag == "DeliveryZone" && hasCube){
            hasCube = false;
            theScore += 1;
        }

        if(skeletonDestroyCounter == 2){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            theScore = 0;
        }

        if(other.tag == "Sphere"){ // award is sphere 
            Destroy(other.gameObject);
            hasSphere = true;
        }

        if(other.tag == "Skeleton" && hasSphere == true){ // if hasSphere = true destroy skeleton or get killed 
            Destroy(other.gameObject);
            skeletonDestroyCounter += 1;
            Debug.Log(skeletonDestroyCounter);
        }
        else if (other.tag == "Skeleton" && hasSphere == false){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            theScore = 0;
        }
    }
}

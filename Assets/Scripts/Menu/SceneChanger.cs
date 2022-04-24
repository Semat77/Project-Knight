using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] int returnToDiffrentScene; // if Victory = -2 if else main menu +1 if else game over -1
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + returnToDiffrentScene);
    }

    public void QuitGame(){
        Debug.Log("Quit!");
    }
}

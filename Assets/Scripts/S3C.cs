using UnityEngine;
using UnityEngine.SceneManagement;

public class S3C : MonoBehaviour
{
    // Load Scene 3 on button click
    public void NextScene() 
    {
        SceneManager.LoadScene("Scene 3");
    }
}
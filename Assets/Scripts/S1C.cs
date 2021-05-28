using UnityEngine;
using UnityEngine.SceneManagement;

public class S1C : MonoBehaviour
{
    // Load Scene 1 on button click
    public void NextScene()
    {
        SceneManager.LoadScene("Scene 1");
    }
}
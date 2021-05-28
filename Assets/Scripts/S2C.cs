using UnityEngine;
using UnityEngine.SceneManagement;

public class S2C : MonoBehaviour
{
    // Load Scene 2 on button click
    public void NextScene()
    {
        SceneManager.LoadScene("Scene 2");
    }
}
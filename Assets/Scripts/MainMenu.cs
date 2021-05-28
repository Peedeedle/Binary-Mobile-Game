using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Load main menu screen when button is pressed
    public void NextScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
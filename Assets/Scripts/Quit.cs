using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // Quit the game
    public void doQuit()
    {
        Debug.Log("Has Quit the game");
        Application.Quit();
    }
}


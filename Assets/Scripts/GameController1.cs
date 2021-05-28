using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameController1 : MonoBehaviour
{
    // create a private function for items below
    [SerializeField]
    private Text targetNumberText;

    private int targetNumber;
    private Calculator1 calculator;

    // Find the correct calculator
    private void Awake()
    {
        calculator = FindObjectOfType<Calculator1>();
    }

    // Choose new number for the player create
    private void ChooseNewNumber()
    {
        targetNumber = UnityEngine.Random.Range(0, 255);
        // When choosing a new number update the UI
        targetNumberText.text = targetNumber.ToString();

    }

    // Force to choose new numbers
    private void Update()
    {
        if (calculator.Total == targetNumber)
        {
            ChooseNewNumber();
        }
    }
}

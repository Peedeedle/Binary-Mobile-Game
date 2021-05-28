using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BitToggle : MonoBehaviour
{
    // Create private int for number to be referenced
    [SerializeField]
    private int number;

    // int = number, bool = on or off
    public event Action<int, bool> OnToggleChanged = delegate { };


    private void Awake()
    {
        //Initially set toggle to off
        GetComponent<Toggle>().isOn = false;
        GetComponent<Toggle>().onValueChanged.AddListener(HandleToggleChanged);
    }

    // Let other items know value has changed
    private void HandleToggleChanged(bool enabled)
    {
        OnToggleChanged(number, enabled);
    }

    private void OnValidate()
    {
        // Get the number that corresponds with the box
        GetComponentInChildren<Text>().text = number.ToString();
        gameObject.name = "Toggle " + number;
    }
}

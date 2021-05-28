using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator1 : MonoBehaviour
{
    // Update text
    [SerializeField]
    private Text totalText;


    // Int to keep track of current values
    public int Total { get; private set; }

    // Set variable for toggles
    private void Start()
    {
        var allToggles = FindObjectsOfType<BitToggle>();
        foreach (var toggle in allToggles)
            toggle.OnToggleChanged += Toggle_OnToggleChanged;
    }

    // if 1 is toggled, add 1 to total etc
    private void Toggle_OnToggleChanged(int number, bool enabled)
    {
        if (enabled)
            Total += number;
        else
            Total -= number;

        totalText.text = Total.ToString();

    }
}

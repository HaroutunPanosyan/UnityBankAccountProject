using System.Collections;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReadInput : MonoBehaviour
{

    [Header("The value we got from the input field")]
    [SerializeField] private string inputText;

    [Header("Showing the reaction to the player")]
    [SerializeField] private GameObject reactionGroup;
    [SerializeField] private TMP_Text reactionTextBox;

    public void GrabFromInputField(string input)
    {
        double amount;
        bool isNumber = double.TryParse(input, out amount);
        if (!isNumber)
        {
            DisplayNegativeReactionToInput();
            isNumber = double.TryParse(input, out amount);
        }
        else
        {
            Convert.ToDouble(inputText);
            inputText = input;
            DisplayReactionToInput();
        }
    }

    private void DisplayReactionToInput()
    {
        reactionTextBox.text = "$" + inputText + " has been deposited into the account.";
        reactionGroup.SetActive(true);
    }
    private void DisplayNegativeReactionToInput()
    {
        reactionTextBox.text = "That is not a number. Please input a valid amount.";
        reactionGroup.SetActive(true);
    }
}

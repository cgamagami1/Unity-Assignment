/* (Colin Gamagami)
 * (ButtonTrigger.cs)
 * (Assignment 7)
 * (Functionality for a trigger that switches a button on and off)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    private bool toggle = false;
    private Button button;
    private ButtonPresser buttonPresser = new ButtonPresser();

    private void Awake()
    {
        button = GameObject.FindGameObjectWithTag("Button").GetComponent<Button>();
        buttonPresser.SetCommand(new SwitchButton(button));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (toggle)
            {
                toggle = false;
                buttonPresser.UnpressButton();
            }
            else
            {
                toggle = true;
                buttonPresser.PressButton();
            }
        }
    }
}

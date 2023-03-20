/* (Colin Gamagami)
 * (ButtonPresser.cs)
 * (Assignment 7)
 * (Implements a Button Presser invoker)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresser
{
    private SwitchButton switchButton;

    public void SetCommand(SwitchButton newSwitchButton)
    {
        switchButton = newSwitchButton;
    }

    public void PressButton()
    {
        switchButton.Execute();
    }

    public void UnpressButton()
    {
        switchButton.Undo();
    }
}

/* (Colin Gamagami)
 * (SwitchButton.cs)
 * (Assignment 7)
 * (implements a switchbutton command)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : Command
{
    private Button button;

    public SwitchButton(Button button)
    {
        this.button = button;
    }

    public void Execute()
    {
        button.SwitchOn();
    }

    public void Undo()
    {
        button.SwitchOff();
    }
}

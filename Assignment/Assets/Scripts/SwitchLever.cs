/* (Colin Gamagami)
 * (SwitchLever.cs)
 * (Assignment 7)
 * (Implements a SwitchLever command)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLever : Command
{
    private Lever lever;

    public SwitchLever(Lever lever)
    {
        this.lever = lever;
    }

    public void Execute()
    {
        lever.SwitchOn();
    }

    public void Undo()
    {
        lever.SwitchOff();
    }
}

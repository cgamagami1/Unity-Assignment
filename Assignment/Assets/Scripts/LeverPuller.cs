/* (Colin Gamagami)
 * (LeverPuller.cs)
 * (Assignment 7)
 * (Implements a Lever Puller invoker)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPuller
{
    private SwitchLever switchLever;

    public void SetCommand(SwitchLever newSwitchLever)
    {
        switchLever = newSwitchLever;
    }

    public void PullLever()
    {
        switchLever.Execute();
    }

    public void UnpullLever()
    {
        switchLever.Undo();
    }
}

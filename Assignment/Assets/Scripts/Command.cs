/* (Colin Gamagami)
 * (Command.cs)
 * (Assignment 7)
 * (Implements a command interface)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
    public void Execute();

    public void Undo();
}

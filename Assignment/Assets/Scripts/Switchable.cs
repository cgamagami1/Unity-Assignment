/* (Colin Gamagami)
 * (Switchable.cs)
 * (Assignment 7)
 * (Defines a switchable interface)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Switchable
{
    public void SwitchOn();

    public void SwitchOff();

    public bool GetIsSwitchOn();
}

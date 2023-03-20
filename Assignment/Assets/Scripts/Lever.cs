/* (Colin Gamagami)
 * (Lever.cs)
 * (Assignment 7)
 * (Implements a switchable lever)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour, Switchable
{
    private bool isSwitchedOn = false;

    public bool GetIsSwitchOn()
    {
        return isSwitchedOn;
    }

    public void SwitchOff()
    {
        isSwitchedOn = false;
        transform.Rotate(new Vector3(-90f, 0f, 0f));
    }

    public void SwitchOn()
    {
        isSwitchedOn = true;
        transform.Rotate(new Vector3(90f, 0f, 0f));
    }
}

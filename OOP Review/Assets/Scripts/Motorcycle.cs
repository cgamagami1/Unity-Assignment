/*
 * (Colin Gamagami)
 * (Motorcycle.cs)
 * (Assignment 1)
 * (implements a concrete motorcycle class)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motorcycle : Vehicle, IExplodeable, IRepairable
{
    public void Explode()
    {
        Debug.Log("Motorcycle exploded");
    }

    public void Repair()
    {
        Debug.Log("Motorcycle repaired");
    }

    public override void StartUp()
    {
        Debug.Log("Starting up motorcycle");
    }
}

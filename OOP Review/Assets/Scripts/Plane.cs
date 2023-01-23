/*
 * (Colin Gamagami)
 * (Plane.cs)
 * (Assignment 1)
 * (implements a concrete plane class)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle, IExplodeable, IRepairable
{
    private float altitude;

    public void Explode()
    {
        Debug.Log("Explode plane");
    }

    public void Repair()
    {
        Debug.Log("Repair plane");
    }

    public override void StartUp()
    {
        Debug.Log("Plane starting up");
    }
}

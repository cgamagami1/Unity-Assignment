/*
 * (Colin Gamagami)
 * (Car.cs)
 * (Assignment 1)
 * (implements a concrete car class)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle, IExplodeable, IRepairable
{
    private float tirePressure;

    public void Explode()
    {
        Debug.Log("Explode car");
    }

    public void Repair()
    {
        Debug.Log("Repair car");
    }

    public override void StartUp()
    {
        Debug.Log("Car starting up");
    }
}

/*
 * (Colin Gamagami)
 * (Rocket.cs)
 * (Assignment 8)
 * (Implements a rocket that takes off and turns blue)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueRocket : Rocket
{
    public Material blueMat;

    public override void MakeBlue()
    {
        mesh.material = blueMat;
    }

    public override void MakeGreen() { }

    public override bool IsBlue()
    {
        return true;
    }
}

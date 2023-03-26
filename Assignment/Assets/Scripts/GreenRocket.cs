/*
 * (Colin Gamagami)
 * (Rocket.cs)
 * (Assignment 8)
 * (Implements a rocket that takes off and turns green)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenRocket : Rocket
{
    public Material greenMat;

    public override void MakeBlue() { }

    public override void MakeGreen()
    {
        mesh.material = greenMat;
    }

    public override bool IsGreen()
    {
        return true;
    }
}

/*
 * (Colin Gamagami)
 * (SmallEnemy.cs)
 * (Assignment 5)
 * (Class for small enemy.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : Enemy
{
    protected Vector3 dimensions = new Vector3(.2f, .2f, .2f);

    protected override void SetSize()
    {
        transform.localScale = dimensions;
    }
}

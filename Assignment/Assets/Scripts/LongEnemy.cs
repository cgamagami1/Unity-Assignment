/*
 * (Colin Gamagami)
 * (LongEnemy.cs)
 * (Assignment 6)
 * (Class for long enemy.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongEnemy : Enemy
{
    protected Vector3 dimensions = new Vector3(1f, 5f, 1f);

    protected override void SetSize()
    {
        transform.localScale = dimensions;
    }
}

/*
 * (Colin Gamagami)
 * (BigEnemy.cs)
 * (Assignment 6)
 * (Class for big enemy.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : Enemy
{
    protected Vector3 dimensions = new Vector3(5f, 5f, 5f);

    protected override void SetSize()
    {
        transform.localScale = dimensions;
    }
}

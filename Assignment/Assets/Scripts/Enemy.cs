/*
 * (Colin Gamagami)
 * (Enemy.cs)
 * (Assignment 5)
 * (Abstact enemy class.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    private void Start()
    {
        SetSize();
    }

    protected abstract void SetSize();
}

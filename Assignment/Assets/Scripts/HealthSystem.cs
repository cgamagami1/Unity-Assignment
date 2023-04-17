/* (Colin Gamagami)
 * (HealthSystem.cs)
 * (Assignment 11)
 * Implements a class that tracks the current health
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem
{
    private int health = 5;

    public void AddHealth()
    {
        health++;
    }

    public void RemoveHealth()
    {
        health--;
    }

    public int GetHealth()
    {
        return health;
    }
}

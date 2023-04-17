/* (Colin Gamagami)
 * (InvincibilityChecker.cs)
 * (Assignment 11)
 * Implements a class that checks if the player is invincible
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityChecker
{
    private bool isInvincible = false;

    public void SetIsInvincible(bool newIsInvincible)
    {
        isInvincible = newIsInvincible;
    }

    public bool CheckIsInvincible()
    {
        return isInvincible;
    }
}

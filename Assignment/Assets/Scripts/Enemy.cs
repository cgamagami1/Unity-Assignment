/*
 * (Colin Gamagami)
 * (Enemy.cs)
 * (Assignment 2)
 * (Handles enemy implementation.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AttackBehavior attackType;

    public void SetAttackType(AttackBehavior newAttackType)
    {
        attackType = newAttackType;
    }

    public string Attack()
    {
        return attackType.Attack();
    }
}

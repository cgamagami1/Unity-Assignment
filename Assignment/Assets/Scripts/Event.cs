/*
 * (Colin Gamagami)
 * (Event.cs)
 * (Assignment 2)
 * (Handles the main gameplay event.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Event : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Enemy enemy;

    public void HideInTree()
    {
        enemy.SetAttackType(new TreeChoppingAttack());
        text.text = enemy.Attack();
    }

    public void HideInPond()
    {
        enemy.SetAttackType(new WaterAttack());
        text.text = enemy.Attack();
    }

    public void RunAway()
    {
        enemy.SetAttackType(new RangedAttack());
        text.text = enemy.Attack();
    }
}

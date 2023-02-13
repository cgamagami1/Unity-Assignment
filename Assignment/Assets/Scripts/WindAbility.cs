/*
 * (Colin Gamagami)
 * (WindAbility.cs)
 * (Assignment 4)
 * (Implements the wind ability decorator)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindAbility : AbilityDecorator
{

    public WindAbility(Ability newAbility) : base(newAbility)
    {
    }

    public override string GetAbilities()
    {
        return ability.GetAbilities() + " Wind Attack";
    }
}

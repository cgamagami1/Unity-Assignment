/*
 * (Colin Gamagami)
 * (WaterAbility.cs)
 * (Assignment 4)
 * (Implements the water ability decorator)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAbility : AbilityDecorator
{

    public WaterAbility(Ability newAbility) : base(newAbility)
    {
    }

    public override string GetAbilities()
    {
        return ability.GetAbilities() + " Water Attack";
    }
}

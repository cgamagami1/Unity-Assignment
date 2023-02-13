/*
 * (Colin Gamagami)
 * (FireAbility.cs)
 * (Assignment 4)
 * (Implments a fire ability decorator)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAbility : AbilityDecorator
{

    public FireAbility (Ability newAbility) : base(newAbility)
    {
    }

    public override string GetAbilities()
    {
        return ability.GetAbilities() + " Fire Attack";
    }
}

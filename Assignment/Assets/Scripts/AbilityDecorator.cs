/*
 * (Colin Gamagami)
 * (AbilityDecorator.cs)
 * (Assignment 4)
 * (Implements an ability decorator)
 */
public abstract class AbilityDecorator : Ability
{
    protected Ability ability;

    public AbilityDecorator (Ability newAbility)
    {
        ability = newAbility;
    }

    public override string GetAbilities()
    {
        return ability.GetAbilities();
    }
}

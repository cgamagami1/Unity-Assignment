/*
 * (Colin Gamagami)
 * (GameManagerA.cs)
 * (Assignment 4)
 * (Implements a game manager)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Ability ability;
    private void Start()
    {
        ability = new BaseAbility();
    }

    private void Update()
    {
        text.text = "Abilities: " + ability.GetAbilities();
    }

    public void AddFireAbility()
    {
        ability = new FireAbility(ability);
    }

    public void AddWaterAbility()
    {
        ability = new WaterAbility(ability);
    }

    public void AddWindAbility()
    {
        ability = new WindAbility(ability);
    }
}

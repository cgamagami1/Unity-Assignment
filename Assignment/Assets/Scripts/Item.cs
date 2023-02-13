/*
 * (Colin Gamagami)
 * (Item.cs)
 * (Assignment 4)
 * (Handles item functionality)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameManager gameManager;
    public string abilityName;

    private void OnTriggerEnter(Collider other)
    {
        switch (abilityName) 
        {
            case "fire":
                gameManager.AddFireAbility();
                break;
            case "water":
                gameManager.AddWaterAbility();
                break;
            case "wind":
                gameManager.AddWindAbility();
                break;
        }

        Destroy(this.gameObject);
    }
}

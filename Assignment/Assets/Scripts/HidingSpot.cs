/*
 * (Colin Gamagami)
 * (HidingSpot.cs)
 * (Assignment 3)
 * (Handles the trigger for the player hiding)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingSpot : MonoBehaviour
{
    public EnemyController enemyController;

    private void OnTriggerEnter(Collider other)
    {
        enemyController.setIsPlayerHiding(true);    
    }

    private void OnTriggerExit(Collider other)
    {
        enemyController.setIsPlayerHiding(false);
    }
}

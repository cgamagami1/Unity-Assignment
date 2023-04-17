/* (Colin Gamagami)
 * (Enemy.cs)
 * (Assignment 11)
 * Implements an enemy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.Damage();
            Destroy(gameObject);
        }
    }
}

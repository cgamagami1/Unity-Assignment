/* (Colin Gamagami)
 * (Health.cs)
 * (Assignment 11)
 * Implements a health cube
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.Health();
            Destroy(gameObject);
        }
    }
}

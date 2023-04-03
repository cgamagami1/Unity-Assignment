/*(Colin Gamagami)
 * (Goal.cs)
 * (Assignment 9)
 * Handles the goal ontriggerenter
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.WinGame();
    }
}

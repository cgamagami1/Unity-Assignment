/*(Colin Gamagami)
 * (Door.cs)
 * (Assignment 9)
 * Handles the door ontriggerenter
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.UnlockDoor();
    }
}

/*(Colin Gamagami)
 * (Key.cs)
 * (Assignment 9)
 * Handles the key ontriggerenter
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.PickUpKey();
    }
}

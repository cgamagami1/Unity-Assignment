/*
* (Colin Gamagami)
* (Trigger.cs)
* (Assignment 12)
* (Implements the shop trigger which displays all inventory items)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.ListAll();
        }
    }
}

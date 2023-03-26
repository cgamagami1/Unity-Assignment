/*
 * (Colin Gamagami)
 * (Rocket.cs)
 * (Assignment 8)
 * (Implements the trigger that makes the rockets take off)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public BlueRocket blueRocket;
    public GreenRocket greenRocket;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            blueRocket.TakeOff();
            greenRocket.TakeOff();
        }
    }
}

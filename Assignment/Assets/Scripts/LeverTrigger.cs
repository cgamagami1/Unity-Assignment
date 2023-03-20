/* (Colin Gamagami)
 * (LeverTrigger.cs)
 * (Assignment 7)
 * (Functionality for a trigger that switches a lever on and off)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour
{
    private bool toggle = false;
    private Lever lever;
    private LeverPuller leverPuller = new LeverPuller();

    private void Awake()
    {
        lever = GameObject.FindGameObjectWithTag("Lever").GetComponent<Lever>();
        leverPuller.SetCommand(new SwitchLever(lever));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (toggle)
            {
                toggle = false;
                leverPuller.UnpullLever();
            }
            else
            {
                toggle = true;
                leverPuller.PullLever();
            }
        }
    }
}

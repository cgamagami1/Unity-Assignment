/* (Colin Gamagami)
 * (GameManager.cs)
 * (Assignment 7)
 * (Implements the gamemanager)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Button switch1;
    public Lever switch2;
    public GameObject door;

    private void Update()
    {
        if (switch1.GetIsSwitchOn() && switch2.GetIsSwitchOn())
        {
            Destroy(door);
        }
    }
}

/*(Colin Gamagami)
 * (GameState.cs)
 * (Assignment 9)
 * Implements the GameState inteface
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameState
{
    public void PickUpKey();
    public void UnlockDoor();
    public void WinGame();
}

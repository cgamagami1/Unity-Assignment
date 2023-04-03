/*(Colin Gamagami)
 * (HasKey.cs)
 * (Assignment 9)
 * Implements the HasKey State
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HasKey : GameState
{
    GameManager gameManager;
    TextMeshProUGUI text;

    public HasKey(GameManager newGameManager)
    {
        gameManager = newGameManager;
        text = GameObject.FindGameObjectWithTag("Text").GetComponent<TextMeshProUGUI>();
    }
    public void PickUpKey()
    {
        text.text = "The key has already been picked up.";
    }

    public void UnlockDoor()
    {
        text.text = "You unlocked the door.";

        gameManager.SetGameState(gameManager.GetOpenedDoorState());
    }

    public void WinGame()
    {
        text.text = "The door must be opened first.";
    }
}

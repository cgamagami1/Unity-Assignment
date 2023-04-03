/*(Colin Gamagami)
 * (OpenedDoor.cs)
 * (Assignment 9)
 * Implements the OpenedDoor State
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenedDoor : GameState
{
    GameManager gameManager;
    TextMeshProUGUI text;

    public OpenedDoor(GameManager newGameManager)
    {
        gameManager = newGameManager;
        text = GameObject.FindGameObjectWithTag("Text").GetComponent<TextMeshProUGUI>();
    }
    public void PickUpKey()
    {
        text.text = "Key has already been picked up.";
    }

    public void UnlockDoor()
    {
        text.text = "Door has already been opened.";
    }

    public void WinGame()
    {
        text.text = "You won the game!";

        gameManager.SetGameState(gameManager.GetWinState());
    }
}

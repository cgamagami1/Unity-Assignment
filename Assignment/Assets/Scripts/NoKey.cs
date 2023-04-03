/*(Colin Gamagami)
 * (NoKey.cs)
 * (Assignment 9)
 * Implements the NoKey State
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoKey : GameState
{
    GameManager gameManager;
    TextMeshProUGUI text;

    public NoKey(GameManager newGameManager)
    {
        gameManager = newGameManager;
        text = GameObject.FindGameObjectWithTag("Text").GetComponent<TextMeshProUGUI>();
    }
    public void PickUpKey()
    {
        text.text = "You picked up the key.";

        gameManager.SetGameState(gameManager.GetHasKeyState());
    }

    public void UnlockDoor()
    {
        text.text = "You need the key first.";
    }

    public void WinGame()
    {
        text.text = "You need to open the door first.";
    }
}

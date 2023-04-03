/*(Colin Gamagami)
 * (Win.cs)
 * (Assignment 9)
 * Implements the Win State
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Win : GameState
{
    GameManager gameManager;
    TextMeshProUGUI text;

    public Win(GameManager newGameManager)
    {
        gameManager = newGameManager;
        text = GameObject.FindGameObjectWithTag("Text").GetComponent<TextMeshProUGUI>();
    }
    
    public void PickUpKey()
    {
        text.text = "Game has already been won.";
    }

    public void UnlockDoor()
    {
        text.text = "Game has already been won.";
    }

    public void WinGame()
    {
        text.text = "Game has already been won.";
    }
}

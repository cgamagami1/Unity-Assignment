/* (Colin Gamagami)
 * (GameStateChecker.cs)
 * (Assignment 11)
 * Implements a class that checks the current game state
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateChecker
{
    private bool isGameOver = false;

    public void SetIsGameOver(bool newIsGameOver)
    {
        isGameOver = newIsGameOver;
    }

    public bool CheckIsGameOver()
    {
        return isGameOver;
    }
}

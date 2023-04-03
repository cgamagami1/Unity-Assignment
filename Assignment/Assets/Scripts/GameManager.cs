/*(Colin Gamagami)
 * (GameManager.cs)
 * (Assignment 9)
 * Implements the Game Manager which acts as a context for the game state
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameState noKey;
    private GameState hasKey;
    private GameState openedDoor;
    private GameState win;

    private GameState gameState;

    private void Awake()
    {
        noKey = new NoKey(this);
        hasKey = new HasKey(this);
        openedDoor = new OpenedDoor(this);
        win = new Win(this);

        gameState = noKey;
    }

    public void SetGameState(GameState newGameState)
    {
        gameState = newGameState;
    }

    public void PickUpKey()
    {
        gameState.PickUpKey();
    }

    public void UnlockDoor()
    {
        gameState.UnlockDoor();
    }

    public void WinGame()
    {
        gameState.WinGame();
    }

    public GameState GetNoKeyState()
    {
        return noKey;
    }

    public GameState GetHasKeyState()
    {
        return hasKey;
    }

    public GameState GetOpenedDoorState()
    {
        return openedDoor;
    }

    public GameState GetWinState()
    {
        return win;
    }
}

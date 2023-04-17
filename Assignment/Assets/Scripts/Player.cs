/* (Colin Gamagami)
 * (Player.cs)
 * (Assignment 11)
 * Implements the Fascade class that contains other subclasses
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private GameStateChecker gameStateChecker;
    private InvincibilityChecker invincibilityChecker;
    private HealthSystem healthSystem;
    public TextMeshProUGUI text;

    private void Start()
    {
        gameStateChecker = new GameStateChecker();
        invincibilityChecker = new InvincibilityChecker();
        healthSystem = new HealthSystem();
    }

    public void Health()
    {
        if (gameStateChecker.CheckIsGameOver()) return;

        healthSystem.AddHealth();
    }

    public void Damage()
    {
        if (invincibilityChecker.CheckIsInvincible()) return;

        if (gameStateChecker.CheckIsGameOver()) return;

        healthSystem.RemoveHealth();
    }

    private void Update()
    {
        text.text = "Collect the yellow health and avoid the blue enemies. Health: " + healthSystem.GetHealth();
    }
}

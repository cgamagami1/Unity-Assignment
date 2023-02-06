/*
 * (Colin Gamagami)
 * (GameManager.cs)
 * (Assignment 3)
 * (Registers the enemies with the enemy controller)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnemyController enemyController;
    public Enemy enemy1;
    public Enemy enemy2;

    private void Awake()
    {
        enemyController.register(enemy1);
        enemyController.register(enemy2);
    }
}

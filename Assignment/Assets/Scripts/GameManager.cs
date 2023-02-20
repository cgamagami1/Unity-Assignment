/*
 * (Colin Gamagami)
 * (GameManager.cs)
 * (Assignment 5)
 * (Spawns a new enemy on left mouse click.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    private EnemyFactory enemyFactory = new EnemyFactory();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnRandomEnemy();
        }
    }

    public void SpawnRandomEnemy()
    {
        GameObject newEnemy = null;

        int rand = Random.Range(0, 3);

        switch (rand)
        {
            case 0:
                newEnemy = enemyFactory.CreateEnemy(enemy, "Big");
                break;
            case 1:
                newEnemy = enemyFactory.CreateEnemy(enemy, "Long");
                break;
            case 2:
                newEnemy = enemyFactory.CreateEnemy(enemy, "Small");
                break;
        }

        Instantiate(newEnemy, transform);
    }
}

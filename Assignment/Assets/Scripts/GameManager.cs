/*
 * (Colin Gamagami)
 * (GameManager.cs)
 * (Assignment 6)
 * (Spawns a new enemy on left mouse click.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    private BigEnemyCreator bigEnemyCreator;
    private SmallEnemyCreator smallEnemyCreator;
    private LongEnemyCreator longEnemyCreator;
    public Transform bigEnemyTransform;
    public Transform smallEnemyTransform;
    public Transform longEnemyTransform;

    private void Awake()
    {
        bigEnemyCreator = new BigEnemyCreator();
        smallEnemyCreator = new SmallEnemyCreator();
        longEnemyCreator = new LongEnemyCreator();
    }

    public void SpawnBigEnemy()
    {
        GameObject newEnemy = bigEnemyCreator.CreateEnemy(enemy);
        Instantiate(newEnemy, bigEnemyTransform);
    }

    public void SpawnSmallEnemy()
    {
        GameObject newEnemy = smallEnemyCreator.CreateEnemy(enemy);
        Instantiate(newEnemy, smallEnemyTransform);
    }

    public void SpawnLongEnemy() 
    {
        GameObject newEnemy = longEnemyCreator.CreateEnemy(enemy);
        Instantiate(newEnemy, longEnemyTransform);
    }
}

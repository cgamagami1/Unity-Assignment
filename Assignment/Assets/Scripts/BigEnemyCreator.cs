/*
 * (Colin Gamagami)
 * (BigEnemyCreator.cs)
 * (Assignment 6)
 * (Handles big enemy creation.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemyCreator : EnemyCreator
{
    public override GameObject CreateEnemy(GameObject enemyObject)
    {
        enemyObject.AddComponent<BigEnemy>();
        return enemyObject;
    }
}

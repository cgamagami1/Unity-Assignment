/*
 * (Colin Gamagami)
 * (LongEnemyCreator.cs)
 * (Assignment 6)
 * (Handles long enemy creation.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongEnemyCreator : EnemyCreator
{
    public override GameObject CreateEnemy(GameObject enemyObject)
    {
        enemyObject.AddComponent<LongEnemy>();
        return enemyObject;
    }
}

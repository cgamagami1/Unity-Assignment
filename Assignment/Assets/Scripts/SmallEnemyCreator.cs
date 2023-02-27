/*
 * (Colin Gamagami)
 * (SmallEnemyCreator.cs)
 * (Assignment 6)
 * (Handles small enemy creation.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemyCreator : EnemyCreator
{
    public override GameObject CreateEnemy(GameObject enemyObject)
    {
        enemyObject.AddComponent<SmallEnemy>();
        return enemyObject;
    }
}

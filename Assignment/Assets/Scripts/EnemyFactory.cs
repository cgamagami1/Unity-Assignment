/*
 * (Colin Gamagami)
 * (EnemyFactory.cs)
 * (Assignment 5)
 * (Handles enemy creation.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory
{
    public GameObject CreateEnemy(GameObject enemyObject, string enemyType)
    {
        switch (enemyType) 
        {
            case "Big":
                enemyObject.AddComponent<BigEnemy>();
                return enemyObject;
            case "Long":
                enemyObject.AddComponent<LongEnemy>();
                return enemyObject;
            case "Small":
                enemyObject.AddComponent<SmallEnemy>();
                return enemyObject;
            default:
                return null;
        }
    }
}

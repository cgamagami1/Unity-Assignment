/* (Colin Gamagami)
 * (EnemySpawner.cs)
 * (Assignment 10)
 * (Implements the script that spawns the enemies from the pool)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        ObjectPooler.Instance.SpawnFromPool("Enemy", transform.position, Quaternion.identity);
    }
}

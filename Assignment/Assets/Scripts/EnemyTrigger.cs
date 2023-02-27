using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public string enemyType;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (enemyType)
            {
                case "big":
                    gameManager.SpawnBigEnemy();
                    break;
                case "small":
                    gameManager.SpawnSmallEnemy();
                    break;
                case "long":
                    gameManager.SpawnLongEnemy();
                    break;
            }
        }
    }
}

/*
 * (Colin Gamagami)
 * (Assignment 5A)
 * (displays win text upon colliding)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGoal : MonoBehaviour
{
    public GameObject winText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            winText.SetActive(true);
        }
    }
}

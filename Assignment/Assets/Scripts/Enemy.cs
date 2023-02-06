/*
 * (Colin Gamagami)
 * (Enemy.cs)
 * (Assignment 3)
 * (Implements an enemy that chases the player until the player hides under a blue arc)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour, Observer
{
    public Transform playerTransform;
    private NavMeshAgent agent;
    private bool isPlayerHiding = false;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void UpdateObserver(bool newIsPlayerHiding)
    {
        isPlayerHiding = newIsPlayerHiding;
    }

    public void Update()
    {
        if (!isPlayerHiding)
        {
            agent.SetDestination(playerTransform.position);
        }
        else
        {
            agent.SetDestination(transform.position);
        }
    }
}

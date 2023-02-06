/*
 * (Colin Gamagami)
 * (EnemyController.cs)
 * (Assignment 3)
 * (Implements an enemy controller that tells the enemies when the player is hiding)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour, Subject
{
    private List<Observer> observers = new List<Observer>();

    private bool isPlayerHiding = false;

    public void notifyObserver()
    {
        foreach (Observer observer in observers)
        {
            observer.UpdateObserver(isPlayerHiding);
        }
    }

    public void register(Observer observerToRegister)
    {
        observers.Add(observerToRegister);
    }

    public void unregister(Observer observerToUnregister)
    {
        observers.Remove(observerToUnregister);
    }

    public void setIsPlayerHiding(bool newIsPlayerHiding)
    {
        isPlayerHiding = newIsPlayerHiding;
        notifyObserver();
    }
}

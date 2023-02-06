/*
 * (Colin Gamagami)
 * (Subject.cs)
 * (Assignment 3)
 * (Implements a subject inteface)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Subject
{
    public void register(Observer observerToRegister);
    public void unregister(Observer observerToUnregister);
    public void notifyObserver();

}

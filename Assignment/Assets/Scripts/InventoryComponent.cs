/*
* (Colin Gamagami)
* (InventoryComponent.cs)
* (Assignment 12)
* (Implements the abstract class for an inventory component which can be an item or section)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryComponent
{
    public virtual void Add(InventoryComponent inventoryComponent)
    {

    }

    public virtual void Remove(InventoryComponent inventoryComonent)
    {

    }

    public virtual InventoryComponent GetComponent(int index)
    {
        return this;
    }

    public abstract string GetItemName();
}

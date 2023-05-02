/*
* (Colin Gamagami)
* (InventoryItem.cs)
* (Assignment 12)
* (Implements an inventory item which has a name)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : InventoryComponent
{
    private string name;

    public InventoryItem(string newName)
    {
        name = newName;
    }

    public override string GetItemName()
    {
        return name;
    }
}

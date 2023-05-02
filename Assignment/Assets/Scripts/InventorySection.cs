/*
* (Colin Gamagami)
* (Inventory Section)
* (Assignment 12)
* (A section for the inventory)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySection : InventoryComponent
{
    public List<InventoryComponent> componentList = new List<InventoryComponent>();

    public string sectionName;

    public InventorySection(string name)
    {
        sectionName = name;
    }

    public override void Add(InventoryComponent inventoryComponent)
    {
        componentList.Add(inventoryComponent);
    }

    public override string GetItemName()
    {
        return sectionName;
    }

    public override void Remove(InventoryComponent inventoryComponent)
    {
        componentList.Remove(inventoryComponent);
    }

    public override InventoryComponent GetComponent(int index)
    {
        return componentList[index];
    }
}

/*
* (Colin Gamagami)
* (GameManager.cs)
* (Assignment 12)
* (Implements the game manager)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public InventorySection inventory;
    public TextMeshProUGUI text;

    private void Awake()
    {
        inventory = new InventorySection("Inventory");
        inventory.Add(new InventoryItem("Cube"));
        inventory.Add(new InventoryItem("Cube"));
        inventory.Add(new InventoryItem("Cube"));
        inventory.Add(new InventorySection("Red Cubes"));
        inventory.GetComponent(3).Add(new InventoryItem("Red Cube"));
        inventory.GetComponent(3).Add(new InventoryItem("Red Cube"));
        inventory.GetComponent(3).Add(new InventoryItem("Red Cube"));
    }

    public void ListAll()
    {
        text.text = inventory.GetComponent(0).GetItemName() + "\n" +
            inventory.GetComponent(1).GetItemName() + "\n" +
            inventory.GetComponent(2).GetItemName() + "\n" +
            inventory.GetComponent(3).GetComponent(0).GetItemName() + "\n" +
            inventory.GetComponent(3).GetComponent(1).GetItemName() + "\n" +
            inventory.GetComponent(3).GetComponent(2).GetItemName();
    }
}

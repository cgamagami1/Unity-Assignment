using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    private InventoryItem item;
    public List<InventoryItem> inventory = new List<InventoryItem>();

    private void Start()
    {
        item = new InventoryItem();
    }
}
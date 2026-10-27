using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UIElements;
using NUnit.Framework.Constraints;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] 
    private List<string> items = new List<string>();
    [SerializeField]
    private TMP_Text inventoryText;

    private void Start()
    {
        UpdateInventoryUI();
    }
    public void AddItem(string itemName)
    {
        items.Add(itemName);
        UpdateInventoryUI();
    }

    public bool HasItem(string itemName)
    {
       return items.Contains(itemName);
    }
    private void UpdateInventoryUI()
    {
        inventoryText.text = "º“¡ˆ«∞";

        foreach(var item in items)
        {
            inventoryText.text += "\n" + item;
        }
    }
}

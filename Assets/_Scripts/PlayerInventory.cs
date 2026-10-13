using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] 
    private List<string> items = new List<string>();

    public void AddItem(string itemName)
    {
        items.Add(itemName);
    }
}

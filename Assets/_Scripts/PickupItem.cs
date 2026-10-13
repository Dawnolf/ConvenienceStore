using UnityEngine;

public class PickupItem : MonoBehaviour,IInteractable
{
    [SerializeField] private string itemName = "»ç°ú";
    [SerializeField] private PlayerInventory inventory;
    public void Interact()
    {
        inventory.AddItem(itemName);
        Destroy(gameObject);
    }
    
}

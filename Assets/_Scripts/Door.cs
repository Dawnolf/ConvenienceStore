using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private string requiredItem = "열쇠";
    public void Interact()
    {
        if (inventory.HasItem(requiredItem))
        {
            Debug.Log("문 열림");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("열쇠가 필요합니다");
        }
    }
}

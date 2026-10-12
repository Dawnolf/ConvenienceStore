using UnityEngine;

public class Drink : MonoBehaviour,IInteractable
{
    public void Interact()
    {
        Debug.Log("음료를 마셨다.");
    }
}

using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private GameObject currentTarget;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log(collision.gameObject.name);
        currentTarget = collision.gameObject;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // 감지 범위 밖
        if (currentTarget == collision.gameObject)
        {
            currentTarget = null;
        }

    }
    public void TryInteract()
    {
        if (currentTarget != null)
        {
            Debug.Log(currentTarget.gameObject.name);
            IInteractable interactable = currentTarget.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}

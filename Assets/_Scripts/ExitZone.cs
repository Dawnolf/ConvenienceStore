using UnityEngine;

public class ExitZone : MonoBehaviour
{
    private bool isCleared = false;
    [SerializeField] private GameObject clearText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isCleared)
        {
            return;
        }

        PlayerInventory player =
            other.GetComponentInParent<PlayerInventory>();

        if (player!=null)
        {
            isCleared = true;
            Debug.Log("게임 클리어!");
            clearText.SetActive(true);
            
        }
    }
}

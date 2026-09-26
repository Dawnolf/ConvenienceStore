using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    public PlayerInputActions inputActions;
    void Awake()
    {
        inputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }
    void Update()
    {
        Vector2 direction = inputActions.Player.Move.ReadValue<Vector2>();
        transform.Translate(direction*speed*Time.deltaTime);
    }
}

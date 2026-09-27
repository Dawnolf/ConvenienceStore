using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    public PlayerInputActions inputActions;
    public Rigidbody2D rb;
    void Awake()
    {
        inputActions = new PlayerInputActions();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }
    void FixedUpdate()
    {
        Vector2 direction = inputActions.Player.Move.ReadValue<Vector2>();
        //transform.Translate(direction*speed*Time.deltaTime);
        rb.MovePosition(rb.position+direction*speed*Time.fixedDeltaTime);
    }
}

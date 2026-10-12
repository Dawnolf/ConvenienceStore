using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    public PlayerInputActions inputActions;
    public Rigidbody2D rb;
    public PlayerInteraction playerInteraction;
    void Awake()
    {
        inputActions = new PlayerInputActions();
        rb = GetComponent<Rigidbody2D>();
        playerInteraction = GetComponentInChildren<PlayerInteraction>();    
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    private void Update()
    {
        if (inputActions.Player.Interact.WasPressedThisFrame())
        {
            playerInteraction.TryInteract();
        }
    }
    void FixedUpdate()
    {
        Vector2 direction = inputActions.Player.Move.ReadValue<Vector2>();
        //transform.Translate(direction*speed*Time.deltaTime);
        rb.MovePosition(rb.position+direction*speed*Time.fixedDeltaTime);
        
    }
}

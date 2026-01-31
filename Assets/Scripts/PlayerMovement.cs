using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float walkSpeed = 2f;
    [SerializeField] private float sprintSpeed = 4f;
    private Rigidbody2D rb;
    private Vector2 input;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = input * speed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        animator.SetBool("IsWalking", true);
        if(context.canceled)
        {
            animator.SetBool("IsWalking", false);
            animator.SetFloat("LastInputX", input.x);
            animator.SetFloat("LastInputY", input.y);
        }
        input = context.ReadValue<Vector2>();
        animator.SetFloat("InputX", input.x);
        animator.SetFloat("InputY", input.y);
    }

    public void Sprint(InputAction.CallbackContext context)
    {
        if (context.started || context.performed)
        {
            animator.SetBool("IsSprinting", true);
            speed = sprintSpeed;
        }
        else if (context.canceled)
        {
            animator.SetBool("IsSprinting", false);
            speed = walkSpeed;
            animator.SetFloat("LastInputX", input.x);
            animator.SetFloat("LastInputY", input.y);
        }
    }
}

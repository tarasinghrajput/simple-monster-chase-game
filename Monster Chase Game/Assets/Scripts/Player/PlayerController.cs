using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Player player;
    private SpriteRenderer sr;
    private Animator animator;
    private string WALK_ANIMATION = "Walk";

    private Rigidbody2D rb;
    private float moveSpeed, jumpForce;
    private bool moveLeft, moveRight;
    private bool isGrounded;



    void Awake()
    {
        player = gameObject.GetComponent<Player>();
        rb = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
        jumpForce = 600f;
        moveLeft = false;
        moveRight = false;
        sr = GameObject.FindWithTag("Player").GetComponent<SpriteRenderer>();
        animator = GameObject.FindWithTag("Player").GetComponent<Animator>();
    }
    void Update()
    {
        if(moveLeft)
        {
            MoveLeft();
        } else if(moveRight)
        {
            MoveRight();
        }
    }

    void FixedUpdate() 
    {
        
    }

    public void MoveLeft()
    {
        moveLeft = true;
        moveSpeed = -10f;
        rb.velocity = new Vector2(moveSpeed, 0f);
        animator.SetBool(WALK_ANIMATION, true);
        sr.flipX = true;
    }
    public void MoveRight()
    {
        moveRight = true;
        moveSpeed = 10f;
        rb.velocity = new Vector2(moveSpeed, 0f);
        animator.SetBool(WALK_ANIMATION, true);
        sr.flipX = false;
    }
    public void Jump()
    {
        if(rb.velocity.y == 0 && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
            // rb.AddForce(new Vector2(0f, -1f), ForceMode2D.Impulse);
        }
    }

    public void StopMoving()
    {
        moveLeft = false;
        moveRight = false;
        rb.velocity = Vector2.zero;
        animator.SetBool(WALK_ANIMATION, false);
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("Ground"))    
            isGrounded = true;
    }
}

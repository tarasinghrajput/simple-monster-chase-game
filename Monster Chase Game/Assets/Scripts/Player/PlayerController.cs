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




    void Awake()
    {
        player = gameObject.GetComponent<Player>();
        rb = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
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
            rb.velocity = new Vector2(-moveSpeed, 0f);
            animator.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }

        if(moveRight)
        {
            rb.velocity = new Vector2(moveSpeed, 0f);
            animator.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
    }

    public void MoveLeft()
    {
        // Player.transform.Translate(-(force * Time.deltaTime), 0, 0);
        moveLeft = true;
    }
    public void MoveRight()
    {
        // Player.transform.Translate(force * Time.deltaTime, 0, 0);
        moveRight = true;
    }
    public void Jump()
    {
        // Player.transform.Translate(0, force * Time.deltaTime, 0);
        if(rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

    public void StopMoving()
    {
        moveLeft = false;
        moveRight = false;
        rb.velocity = Vector2.zero;
    }
}

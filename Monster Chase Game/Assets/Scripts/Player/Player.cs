using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // private string GROUND_TAG = "Ground";
    private string ENEMY_TAG = "Enemy";
    // private bool isGrounded;
    /*
    //it make the private variable to acces from unity editor
    // private float moveForce = 10f;

    //it make the private variable to acces from unity editor
    private float jumpForce = 11f;

    private float movementX;

    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;
    private string WALK_ANIMATION = "Walk";


    private void Awake() 
    {
        myBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
    }

    void FixedUpdate() 
    {
        PlayerJump();
    }

 /*
    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }
    public void AnimatePlayer()
    {
        // we are going to the right side
        if(movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        } else if(movementX < 0) // we are going to the left side
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        } else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }

    void PlayerJump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
    */

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        // if(collision.gameObject.CompareTag(GROUND_TAG))    
        //     isGrounded = true;

        if(collision.gameObject.CompareTag(ENEMY_TAG))    
            Destroy(gameObject);
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(ENEMY_TAG))
            Destroy(gameObject);
    } 
}

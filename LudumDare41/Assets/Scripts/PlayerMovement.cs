using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rb;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    public float speed, jumpForce;
    public KeyCode left, right, jump;

    Animator animator;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
	}

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update () {

        animator.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        animator.SetBool("isOnGround", grounded);

        if (Input.GetKey(left))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if (Input.GetKey(right))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (Input.GetKey(jump) && grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
       
		if(rb.velocity.x < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }else
        {
            transform.localScale = new Vector2(1, 1);
        }
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJump : MonoBehaviour
{
    Rigidbody2D rb;            // Rigidbody2D Ŭ������ ���� ���� rb
    public float jumpPower = 600f, speed = 5f;    // jumpPower���� ���� 
    public bool doubleJump = false;
    public bool isGround = false;
    float moveX;
    // Start is called before the first frame update
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (rb.velocity.y == 0)
            isGround = true;
        else
            isGround = false;

        if (isGround)
            doubleJump = true;

        if (isGround && Input.GetKeyDown(KeyCode.Space))
            JumpAddForce();
        else if (doubleJump && Input.GetKeyDown(KeyCode.Space))
        {
            JumpAddForce();
            doubleJump = false;
        }

        moveX = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(moveX, rb.velocity.y);
    }
    
    void JumpAddForce()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(Vector2.up * jumpPower);
    }
}

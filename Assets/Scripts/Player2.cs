using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float moveSpeed;
    public float jumpAmount;

    public KeyCode rightKey;
    public KeyCode leftKey;
    public KeyCode jumpKey;

    Rigidbody2D rb;

    Vector3 velocity;

    public bool IsGrounded;

    public Animator animator2; //animasyon1

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        

        if (Input.GetKey(rightKey))
        {
            velocity = new Vector3(Input.GetAxis("Horizontal2"), 0f);
            transform.position += velocity * moveSpeed * Time.deltaTime;

            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        else if (Input.GetKey(leftKey))
        {
            velocity = new Vector3(Input.GetAxis("Horizontal2"), 0f);
            transform.position += velocity * moveSpeed * Time.deltaTime;

            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        else
        {
            velocity = new Vector3(0f, 0f, 0f); //newwwwwwww, animasyonun çalışması için, bir düğmeye basılmadığında velocityi 0 yapıyor
        }

        if (Input.GetKeyDown(jumpKey) && IsGrounded)
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
        }

        if (IsGrounded == false && Mathf.Approximately(rb.velocity.y, 0))
        {
            IsGrounded = true;
        }

        animator2.SetFloat("Speed2", Mathf.Abs(velocity.x)); // animasyon2
        animator2.SetBool("IsJumping2",!IsGrounded); // animasyon3
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GrassGround")
        {
            IsGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GrassGround")
        {
            IsGrounded = false;
        }
    }

}

    

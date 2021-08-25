using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;
    public Animator animator; // animasyon satırı 1

    public float speedAmount;
    public float jumpAmount;

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal"))); // animasyon satırı 2

        if(Input.GetKeyDown(KeyCode.UpArrow) && !animator.GetBool("IsJumping")) //eski hali: if(Input.GetButtonDown("Jump") && !animator.GetBool("IsJumping"))
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true); // animasyon satırı 3
        }

        if(animator.GetBool("IsJumping") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            animator.SetBool("IsJumping", false);
        }



        if (Input.GetAxisRaw("Horizontal")== -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GrassGround")
        {
            animator.SetBool("IsJumping", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GrassGround")
        {
            animator.SetBool("IsJumping", true);
        }
    }
}

    

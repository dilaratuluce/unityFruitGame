using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class fruitMovement : MonoBehaviour
{
    public Rigidbody2D rgb;
    public float fruitJumpAmount;

    Vector3 lastVelocity; // ekledim
    Collider2D f_collider; //bugün yeni

    
    bool dusmus;
    float i;
    bool beklemeTamamlandi;
    
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        f_collider = GetComponent<Collider2D>();

        i = 1; //15 ağust
        beklemeTamamlandi = false; //15 ağust
 

    }

    IEnumerator birazbekle(float saniye) // 15 ağst (zaman kullanılan şeyler bu şekilde bir coroutine içinde yazılabiliyor)
    {
        yield return new WaitForSecondsRealtime(saniye);
        beklemeTamamlandi = true;
    }


    void Update()
    {
        lastVelocity = rgb.velocity; // ekledim

        if (dusmus == true && i >= 0 && beklemeTamamlandi) // 15 ağust
        {
            i -= 0.005f;
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, i);

            if (i <= 0) //----> 26 ağust
            {
                Destroy(this.gameObject);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "playerTag")
        {
            rgb.AddForce(Vector3.up * fruitJumpAmount, ForceMode2D.Impulse);
        }

        if(collision.gameObject.tag == "wall") //
        {
            var speed = lastVelocity.magnitude; // ekledim
            var direction = Vector3.Reflect(lastVelocity.normalized,collision.contacts[0].normal); //ekledim
            rgb.velocity = direction * speed; // ekledim
        }

        if(collision.gameObject.tag == "grassGround")  // bugün yeni, meyveler düşünce eziliyor
        {
            f_collider.isTrigger = true;
            transform.position = new Vector3(transform.position.x, -4.1f, 0);
            transform.localScale = new Vector3(6,2,0);

            rgb.gravityScale = 0;
            rgb.velocity = Vector2.zero;


            StartCoroutine(birazbekle(3)); // 15 ağust
            dusmus = true; //15 ağust
             
        }
    }

    public float maxSpeed; // fruit fazla hızlanıp uçmasın diye kod
    void FixedUpdate()
    {
        if (rgb.velocity.magnitude > maxSpeed)
        {
            rgb.velocity = rgb.velocity.normalized * maxSpeed;
        }
    }
}

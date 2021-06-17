using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float jetpackForce;
    public float MoveSpeed;
    public Animator animator;

    public ParticleSystem jetpack;

    bool isDead = false;

    public int coins;
    public Text TextCoins;

    //public GameObject restart;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        // restart.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Laser"))
        {
            isDead = true;
            //restart.SetActive(true);
        }
        if (collision.CompareTag("Coin"))
        {
            coins++;
            TextCoins.text = coins.ToString();
            Destroy(collision.gameObject);
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && isDead == false)
        {
            rigidbody.AddForce(new Vector2(0, jetpackForce));
            if (jetpack.emissionRate <= 500)
            {
                jetpack.emissionRate += 50;
            }            
        }
        else
        {
            jetpack.emissionRate -= 60;
        }
        if (isDead == false)
        {
            Vector2 newVelocity = rigidbody.velocity;
            newVelocity.x = MoveSpeed;
            rigidbody.velocity = newVelocity;
        }        
    }
    void Update()
    {
        if (transform.position.y <= -2)
        {
            animator.SetBool("Grounded", true);
        }
        else
        {
            animator.SetBool("Grounded", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public Vector2 jumpHeight;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jumpHeight, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * movement, rb.velocity.y);

       
    }
}

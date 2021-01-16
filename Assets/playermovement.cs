using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed; //moving speed 
    public float jp;//jump power
    private Rigidbody2D rb;
    public float moveInput;// determent left or right.
    public float jt; //jumptime
    public bool cj = false; // can jump

    public GameObject attack;

    public LayerMask Ground; // what is the groud
    // Update is called once per frame

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }
    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
    void Update()
    {
     if (cj && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jp;
            cj = false;
        }
     if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(attack);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        cj = true; 
    }
}
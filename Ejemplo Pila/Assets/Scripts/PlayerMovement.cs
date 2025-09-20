using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    
    private Animator animator;
    private Rigidbody2D _Rigidbody2D;

    
    public float horizontal;
    public float vertical; //No se usa
    public float speed = 5f;
    public float jumpForce = 3f;
    
    private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");  //Movimiento horizontal

        animator.SetFloat("speed", Mathf.Abs(horizontal)); //Animacion de correr

        if (Input.GetButtonDown("Jump") && !isGrounded)
        {
            _Rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("isJumping", true);
            isGrounded = true;
        }


    }

    private void FixedUpdate()
    {
        _Rigidbody2D.velocity = new Vector2(horizontal, _Rigidbody2D.velocity.y);
    }


        

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("isJumping", false);
        }
    }

    
}

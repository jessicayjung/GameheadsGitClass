using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public float speed;
    public float jumpForce = 1.0f;
    private float currentSpeed = 0.0f;
    private BoxCollider2D pCollider;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float currentSpeed = 0.0f;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentSpeed -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentSpeed += speed;
        }
        rb.AddForce(new Vector2(currentSpeed * Time.deltaTime, 0.0f), ForceMode2D.Impulse);

        if (Input.GetKeyDown(KeyCode.Space) && !IsGrounded())
       
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(pCollider.bounds.center, pCollider.bounds.size, 0f, Vector2.down, 1f);
        return raycastHit;
    }
}

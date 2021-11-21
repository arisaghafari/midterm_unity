using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodleMove : MonoBehaviour
{
    private Vector3 moveVector;
    public float jumpAmount = 8f;
    public Rigidbody2D rb;
    private float factor = 0.05f;
    public bool canJump;
    public float maxY;
    void Start()
    {
        moveVector = new Vector3(1 * factor, 0, 0);
        canJump = true;
        maxY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(maxY < transform.position.y)
        {
            maxY = transform.position.y;
        }
        if (canJump)
        {
            rb.AddForce(transform.up * jumpAmount, ForceMode2D.Impulse);
            canJump = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += moveVector;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= moveVector;
        }
        if(transform.position.x > 10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            canJump = true;
        }
    }
}

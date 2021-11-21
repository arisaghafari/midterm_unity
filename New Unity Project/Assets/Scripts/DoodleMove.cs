using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodleMove : MonoBehaviour
{
    private Vector3 moveVector;
    public float jumpAmount = 8f;
    public Rigidbody2D rb;
    public float factor = 0.03f;
    public bool canJump;
    void Start()
    {
        moveVector = new Vector3(1 * factor, 0, 0);
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canJump)
        {
            rb.AddForce(transform.up * jumpAmount, ForceMode2D.Impulse);
            canJump = false;
        }
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpAmount, ForceMode2D.Impulse);
            Debug.Log("jump");
        }*/
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += moveVector;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= moveVector;
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

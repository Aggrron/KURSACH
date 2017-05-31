using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public float speed = 7f;

    private bool faceRight = true;
    private Rigidbody2D rb;
    private float direction = -1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(speed * direction * Time.deltaTime, rb.velocity.y);    
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            direction *= -1f;
            flip();
        }
    }

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
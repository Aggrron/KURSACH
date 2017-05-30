using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercntrl : MonoBehaviour {

    public float speed = 20f;
    private Rigidbody2D rb;
	public bool floor;
	public int force;
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right*moveX*speed*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector2.up * force);
	}
	void OnCollisionEnter(Collision other){
		//if (Input.GetKeyDown(KeyCode.Space))
		//rb.AddForce(Vector2.up * 10000);
	}
}

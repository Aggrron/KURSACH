using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float speed = 10f;
    public float jumpForce = 700f;

    private Rigidbody2D rb;
    private bool faceRight = true;

	void Start ()
    {
        rb = GetComponent <Rigidbody2D> ();
	}
    

    void Update ()
    {
        float move = Input.GetAxis ("Horizontal");
        rb.MovePosition (rb.position + Vector2.right * move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)) rb.AddForce(Vector2.up * jumpForce);

        if (move > 0 && !faceRight) flip();
        else if (move < 0 && faceRight) flip();
	}

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy") SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
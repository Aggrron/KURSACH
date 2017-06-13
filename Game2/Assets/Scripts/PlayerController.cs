using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float speed = 700f;
    public float run = 1.5f;
    public float jumpForce = 7000f;
    public float jumpMax = 15f;
    public float jumpValue = 0f;

    private Rigidbody2D rb;
    private bool faceRight = true;
	private Animator anim;

  /*  public Transform groundCheck;
    public float groundRadius = 0.2f;
    public bool onGround;
    public LayerMask whatIsGround;*/

    void Start ()
    {
		anim = GetComponent<Animator> ();
        rb = GetComponent <Rigidbody2D> ();
	}
    
    void FixedUpdate ()
    {
       // onGround = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        float move = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(move * speed *Time.deltaTime, rb.velocity.y);
        if (Input.GetKey(KeyCode.LeftShift)) rb.velocity = new Vector2(run * move * speed * Time.deltaTime, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space)) //rb.AddForce(Vector2.up * jumpForce);   //ДЕРГАННЫЙ ПРЫЖОК
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);   //ПЛАВНЫЙ ПРЫЖОК

      
        if (move > 0 && !faceRight) flip();
        else if (move < 0 && faceRight) flip();
		anim.SetFloat("Speed", Mathf.Abs(move));


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

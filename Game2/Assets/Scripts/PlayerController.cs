using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float speed = 10f;
    public float speedBoost = 1.5f;
    public float jumpForce = 10f;

    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public bool GroundCheck = false;
    public LayerMask whatIsGround;

    public Transform wallCheck;
    public float wallRadius = 0.2f;
    public bool WallCheck = false;
    public LayerMask whatIsWall;
    public PhysicsMaterial2D forGroundMaterial;
    public PhysicsMaterial2D forWallMaterial;

    private Rigidbody2D rb;
    private bool faceRight = true;
	private Animator anim;

    void Start ()
    {
		anim = GetComponent<Animator> ();
        rb = GetComponent <Rigidbody2D> ();
	}
    
    void FixedUpdate ()
    {
        GroundCheck = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
        WallCheck = Physics2D.OverlapCircle(wallCheck.position, wallRadius, whatIsWall);
        if (!WallCheck || !GroundCheck) rb.sharedMaterial = forWallMaterial;
        else rb.sharedMaterial = forGroundMaterial;

        float move = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);
        if (Input.GetKey(KeyCode.LeftShift)) rb.velocity = new Vector2(speedBoost * move * speed * Time.deltaTime, rb.velocity.y);

        if (GroundCheck && Input.GetKeyDown(KeyCode.Space)) rb.velocity = new Vector2(rb.velocity.x, jumpForce);   //ПЛАВНЫЙ ПРЫЖОК
            //rb.AddForce(Vector2.up * jumpForce);   //ДЕРГАННЫЙ ПРЫЖОК

        if (move > 0 && !faceRight) flip();
        else if (move < 0 && faceRight) flip();

		anim.SetFloat("Speed", Mathf.Abs(move));
    }

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Enemy") SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }
}

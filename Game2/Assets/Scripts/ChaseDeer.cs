using UnityEngine;
using UnityEngine.SceneManagement;

public class ChaseDeer : MonoBehaviour {
    public Transform EndPoint;
  
    private bool faceRight = true;

    void Update ()
    {
		transform.position = Vector2.MoveTowards (transform.position, EndPoint.position, Time.deltaTime);
        if (transform.position.x < EndPoint.transform.position.x && !faceRight) flip();
        else if (transform.position.x > EndPoint.transform.position.x && faceRight) flip();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
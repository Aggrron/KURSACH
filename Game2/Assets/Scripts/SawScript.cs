using UnityEngine;
using UnityEngine.SceneManagement;

public class SawScript : MonoBehaviour {
    
	public  float rotateSpeed;

	void Update ()
    {
		transform.Rotate(new Vector3(0f, 0f, rotateSpeed));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") 
            //other.transform.position = respawn.transform.position;   
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

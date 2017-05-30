using UnityEngine;
using UnityEngine.SceneManagement;

public class SawScript : MonoBehaviour {
    
	void Update ()
    {
        transform.Rotate(new Vector3(0f, 0f, -20f));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") 
            //other.transform.position = respawn.transform.position;   
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class DieSpace : MonoBehaviour {
    //public GameObject respawn;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player") 
            //other.transform.position = respawn.transform.position;   
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

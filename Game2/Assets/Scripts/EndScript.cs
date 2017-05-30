using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            //other.transform.position = respawn.transform.position;   
            SceneManager.LoadScene("lvl 2");
    }
}
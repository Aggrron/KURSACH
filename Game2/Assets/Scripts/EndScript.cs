using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") SceneManager.LoadScene("lvl 2");
    }
}
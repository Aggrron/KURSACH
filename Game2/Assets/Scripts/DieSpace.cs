using UnityEngine;
using UnityEngine.SceneManagement;

public class DieSpace : MonoBehaviour {

    void OnTriggerEnter2D (Collider2D obj)
    {
        if (obj.tag == "Player") SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript2 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.tag == "Player") SceneManager.LoadScene("lvl 3");
	}
}
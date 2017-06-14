using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMove : MonoBehaviour {
    public GameObject target;

	void Update ()
    {
        transform.position = new Vector3 (target.transform.position.x, target.transform.position.y, -10f);
        if (Input.GetKeyDown(KeyCode.Escape)) SceneManager.LoadScene("main menu");
        if (Input.GetKeyDown(KeyCode.L)) SceneManager.LoadScene("Training Scene");
    }
}
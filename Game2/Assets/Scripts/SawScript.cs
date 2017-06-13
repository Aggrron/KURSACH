using UnityEngine;
using UnityEngine.SceneManagement;

public class SawScript : MonoBehaviour {
   public float Speed = 10f;

	void Update ()
    {
		transform.Rotate(new Vector3(0f, 0f, Speed * Time.deltaTime));
    }
}
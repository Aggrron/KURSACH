using UnityEngine;

public class CameraMove : MonoBehaviour {
    public GameObject target;

	void Update ()
    {
        transform.position = new Vector3 (target.transform.position.x, target.transform.position.y, -10f);
    }
}
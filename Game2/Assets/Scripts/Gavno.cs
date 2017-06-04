using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gavno : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown(Collider2D other) {
		SceneManager.LoadScene("Training Scene");
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

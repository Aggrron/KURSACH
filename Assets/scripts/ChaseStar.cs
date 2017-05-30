using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseStar : MonoBehaviour {

	public Transform EndPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, EndPoint.position, Time.deltaTime);
	}
}

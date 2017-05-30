using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseDeer : MonoBehaviour {

	public Transform EndPoint;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, EndPoint.position, Time.deltaTime);
	}
}

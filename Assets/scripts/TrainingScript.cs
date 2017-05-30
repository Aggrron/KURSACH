using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingScript : MonoBehaviour {


	void Awake()
	{
		print ("Testing Awake Function");
	}
	void Start () {
		print ("Testing Start Function");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Space))
		{
			print	("SPACE");
		}

	}
}

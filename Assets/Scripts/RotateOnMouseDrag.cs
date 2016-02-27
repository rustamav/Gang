﻿using UnityEngine;
using System.Collections;

public class RotateOnMouseDrag : MonoBehaviour {



	public float speed = 1.0f;
	public float friction = 1.0f;
	//public float lerpSpeed = 10f; //not used at the moment
	float xDeg = 0.0f;
	//float yDeg = 0.0f;

	private bool rotate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (rotate) {
			Rotate ();
		}
	}

	void OnMouseDown(){
		if (Input.GetMouseButton (0)) {
			rotate = true;
		}
	}

	void OnMouseUp(){
			rotate = false;
	}

	private void Rotate() {
		xDeg = Input.GetAxis ("Mouse X") * speed * friction;
		transform.Rotate(new Vector3(xDeg,0,0)); //TODO: Not sure how to choose the axis of rotation
	}

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentPlayer : MonoBehaviour {

	public int speed;
	private Rigidbody rb;
	void Start () {	
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 moviment = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(moviment*speed);

	}
}
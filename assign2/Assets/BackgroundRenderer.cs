﻿using UnityEngine;
using System.Collections;

public class BackgroundRenderer : MonoBehaviour {
	[SerializeField]
	private float _squareSize = 10;
	
	public float SquareSize {
		get { return _squareSize; }
		set { _squareSize = value; }
	}
	
	void Update () {
		/* 	Optional: Have a check here to only call this code when
		 *  the screen changes dimensions or when the camera is modified in any way.
		 *	This code is called more times than it has to.
		 */
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
		transform.position = new Vector3(transform.position.x, transform.position.y, 1);
		transform.localScale = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
		float repY = transform.localScale.y / transform.localScale.x * _squareSize;
		
		GetComponent<Renderer>().material.SetFloat("RepeatX", _squareSize);
		GetComponent<Renderer>().material.SetFloat("RepeatY", repY);
}
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatingbackground : MonoBehaviour {

	private BoxCollider2D groundCollider;
	private float groundHorizontalLength;

	// Use this for initialization
	void Start () {
		groundCollider = GetComponent<BoxCollider2D> ();
		groundHorizontalLength = groundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -groundHorizontalLength)
		{
			RepositionBackground ();
		}
	}

	private void RepositionBackground()
	{
		Vector2 groundOffSet = new Vector2 (groundHorizontalLength * 3f, 0);

		transform.position = (Vector2)transform.position + groundOffSet;
	}
}

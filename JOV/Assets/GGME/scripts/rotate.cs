﻿using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
    public float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, speed);
	}
}

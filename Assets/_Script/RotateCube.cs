﻿using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0f, 1f, 0f));
	}
}

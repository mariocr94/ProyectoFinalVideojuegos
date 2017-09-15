﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatBeha : MonoBehaviour {

	Vector3 startPoint;

	// Use this for initialization
	void Start () {
		startPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float x = startPoint.x;
		float y = 3*Mathf.Sin(Time.timeSinceLevelLoad) + startPoint.y + 1.5f;
		float z = startPoint.z;

		transform.position = new Vector3 (x, y, z);


	}
}

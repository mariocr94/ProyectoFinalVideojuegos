using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatBehaX : MonoBehaviour {

	Vector3 startPoint;

	// Use this for initialization
	void Start () {
		startPoint = transform.position;
	}

	// Update is called once per frame
	void Update () {
		float x = -3 * Mathf.Cos (Time.timeSinceLevelLoad) + startPoint.x + 2f;
		float y = startPoint.y;
		float z = startPoint.z;

		transform.position = new Vector3 (x, y, z);


	}
}
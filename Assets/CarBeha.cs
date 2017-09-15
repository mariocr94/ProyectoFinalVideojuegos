using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBeha : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		int direccion = 1;

		if (transform.position.z < -10 ){
			transform.Translate(0, 0, -20);
			direccion = -1;
		}

		transform.Translate(0, 0, direccion * 15 * Time.deltaTime);
		
	}

	void OnCollisionEnter (Collision c){

		//c.transform.Translate(0, - 8 ,0);


	}
}

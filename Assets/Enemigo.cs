using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

	Vector3 startPos;

	private GUIStyle guiStyle = new GUIStyle();
	private bool showText = false;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		float x = -5 * Mathf.Sin (Time.timeSinceLevelLoad) + startPos.x+5;
		float y = startPos.y;
		float z = startPos.z;

		transform.position = new Vector3 (x, y, z);


	}

	void OnCollisionEnter(Collision c){
		showText = false;
		c.transform.Translate(0, - 8 ,0);
	}

	void OnGUI()
	{
		if (showText){
			guiStyle.fontSize = 48;

			//GUILayout.Label ("Te la pelaste", guiStyle);
			GUI.Label (new Rect(100, Screen.height/2, Screen.width/2 + 200, Screen.height/2 + 300), "Wasted!", guiStyle);
		}

	}

}

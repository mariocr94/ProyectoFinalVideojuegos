using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour {
	public float speed;
	public float jumpSpeed;
	public Rigidbody rb;
	public bool jumping = false;

	private Vector3 startPoint;
	private float startTime;

	private GUIStyle guiStyle = new GUIStyle();

	float duration = 1.0f;
	Vector3 endPoint;
	private bool showText = false;
	private bool showText2 = false;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();

		startPoint = transform.position;
		startTime = Time.time;

	}
	
	// Update is called once per frame
	void Update () {

		float h = Input.GetAxisRaw ("Horizontal");

		transform.Translate (h * speed * Time.deltaTime, 0, 0, Space.World);


		// secuencia de brinco desde http://answers.unity3d.com/questions/190837/make-a-rigidbody-jump-global-up.html

		if (Input.GetKeyDown (KeyCode.Space)){
			if (!jumping) {
				jumping = true;
				rb.velocity += jumpSpeed * Vector3.up;

			}
		}
//		if (rb.velocity.y == 0) {
//			jumping = false;
//		}
//
//		if (rb.velocity.y != 0) {
//			jumping = true;
//
//		}

		if (transform.position.y < -3) {
			showText = true;
		}

		if (transform.position.y < -20) {
			showText = false;
			transform.position = new Vector3 (24f, 6.76f, 0f);
			//transform.position = Vector3.Lerp (startPoint, endPoint, (Time.time - startTime));
			//transform.position.y = 1;
		}

		if (transform.position.x > 184) {
			showText2 = true;
			//transform.position = new Vector3 (24f, 6.76f, 0f);
			//transform.position = Vector3.Lerp (startPoint, endPoint, (Time.time - startTime));
			//transform.position.y = 1;
		}



	}

	void OnCollisionEnter(Collision c){
		jumping = false;
	}

	void OnGUI()
	{
		if (showText){
			guiStyle.fontSize = 48;

			//GUILayout.Label ("Te la pelaste", guiStyle);
			GUI.Label (new Rect(100, Screen.height/2, Screen.width/2 + 200, Screen.height/2 + 300), "Wasted!", guiStyle);
		}
		if (showText2){
			guiStyle.fontSize = 48;

			//GUILayout.Label ("Te la pelaste", guiStyle);
			GUI.Label (new Rect(100, Screen.height/2, Screen.width/2 + 200, Screen.height/2 + 300), "Respects Bruh!", guiStyle);
		}

	}



}

using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed;
	public float jumpforce;
	public bool grounded;

	void Update () {
		Movement ();	//Call Movement Function

		if (Input.GetKey(KeyCode.Space) && grounded==true){
			Jump ();	//Call Jump Function
		}
	}

	void Movement () {
		float f = Input.GetAxis ("Horizontal");	//Save Horizontal Pos
		GetComponent<Transform>().Translate(Vector3.right * f * Time.deltaTime * speed);	//Translate
	}

	void Jump () {
			Rigidbody r = GetComponent<Rigidbody> ();
			r.AddForce (Vector3.up * jumpforce);
		}

	void OnCollisionEnter(Collision collision){
		if (collision.collider.gameObject.tag == "Ground") {
			grounded = true;
		}
	}
		
	void OnCollisionStay(Collision collision){
		if (collision.collider.gameObject.tag == "Ground") {
			grounded = true;
		}
	}
		
	void OnCollisionExit(Collision collision){
		if (collision.collider.gameObject.tag == "Ground") {
			grounded = false;
		}
	}
}

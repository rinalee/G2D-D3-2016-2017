using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speedFactor = 1f;
	public float jumpForce = 10f;
	Rigidbody rigidbody;	// Rigidbody Variable
	bool grounded;

	void Start (){
		rigidbody = GetComponent<Rigidbody> ();	// Initialize Rigidbody Variable
	}

	void Update () {
		Movement ();	// Calls Movement Function
		if (Input.GetButtonDown("Jump") && grounded == true){
			Jump ();	//Call Jump Function
		}
	}

	void Movement (){
		float speedX = Input.GetAxis ("Horizontal") * speedFactor;	// Save detected input into speedX Variable

		// Apply speedX's float variable to Rigidbody

		// Save player's Velocity in a variable
		Vector3 velocity = rigidbody.velocity;
		velocity.x = speedX;	// Apply speedX to Player's velocity
		rigidbody.velocity = velocity;	// Apply new Velocity to Rigidbody's Velocity

	}

	void Jump () {
		Vector3 velocity = rigidbody.velocity;
		velocity.y = jumpForce;	// Apply speedX to Player's velocity
		rigidbody.velocity = velocity;	// Apply new Velocity to Rigidbody's Velocity
	}

	// Grounded Conditions

	// Enter in Ground
	void OnCollisionEnter(Collision collision){
		if (collision.collider.gameObject.tag == "Ground") {
			grounded = true;
		}
	}
	// Stay in Ground
	void OnCollisionStay(Collision collision){
		if (collision.collider.gameObject.tag == "Ground") {
			grounded = true;
		}
	}
	// Leave Ground
	void OnCollisionExit(Collision collision){
		if (collision.collider.gameObject.tag == "Ground") {
			grounded = false;
		}
	}
}

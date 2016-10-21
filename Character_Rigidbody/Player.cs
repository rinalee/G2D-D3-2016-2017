using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Rigidbody rigidbody;	// Rigidbody Variable

	void Start (){
		rigidbody = GetComponent<Rigidbody> ();	// Initialize Rigidbody Variable
	}

	void Update () {
		Movement ();	// Calls Movement Function
	}

	void Movement (){
		float speedX = Input.GetAxis ("Horizontal");	// Save detected input into speedX Variable

		// Apply speedX's float variable to Rigidbody

		// Save player's Velocity in a variable
		Vector3 velocity = rigidbody.velocity;
		velocity.x = speedX;	// Apply speedX to Player's velocity
		rigidbody.velocity = velocity;

	}
}

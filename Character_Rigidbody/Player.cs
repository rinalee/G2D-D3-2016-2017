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

	}
}

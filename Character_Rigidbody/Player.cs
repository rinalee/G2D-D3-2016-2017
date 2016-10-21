using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Movement ();	// Calls Movement Function
	}

	void Movement (){
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
	}
}

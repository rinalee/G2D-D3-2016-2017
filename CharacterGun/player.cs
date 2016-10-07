using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private float speedx;
	public float acceleration = 1f;
	public bool grounded;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		Movement ();	//Call Movement Function
	}

	void Movement () {
		float f = Input.GetAxis ("Horizontal");	//Save Horizontal Pos
		GetComponent<Transform>().Translate(Vector3.right * f);
	}
}

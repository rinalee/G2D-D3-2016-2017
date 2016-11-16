using UnityEngine;
using System.Collections;

public class Player3 : MonoBehaviour {
	Rigidbody rigid;
	float speedX;
	float speedY;
	public float speedForce = 10f;
	public float jumpForce = 5f;
	public float wallJumpForce = 5f;
	bool grounded;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") && grounded == true){
			Jump ();	//Call Jump Function
		}
		Move();
		}

	void Move(){
		speedX = Input.GetAxis ("Horizontal");
		speedY = Input.GetAxis ("Vertical");

		rigid.AddForce( new Vector3 (speedX * speedForce, 0f, speedY * speedForce));
	}

	void Jump(){
		rigid.velocity = new Vector3 (rigid.velocity.x, jumpForce, rigid.velocity.z);
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

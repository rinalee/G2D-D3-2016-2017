using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour {
	// Variables
	public GameObject laBalle;
	public List<GameObject> listBalle = new List<GameObject>();
	public List<List<Rewind>> memory = new List<List<Rewind>>();

	public class Rewind{
		public Vector3 position;
		public Vector3 velocity;
	}

	// Use this for initialization
	void Start () {

		Writing ();
		
		// Ball Spawn
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				for (int k = 0; k < 10; k++) {
					listBalle.Add (Instantiate(laBalle, new Vector3(i,j,k), Quaternion.identity)as GameObject);
				}
			}
		}
	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.Return)) {
			Reading ();
		}

		if (Input.GetKeyUp (KeyCode.Return)) {
			Writing ();
		}
	}

	// Switch from Load to Save
	void Writing(){
		StopAllCoroutines();
		StartCoroutine (WriteMemory ());
	}

	// Switch from Save to Load
	void Reading(){
		StopAllCoroutines();
		StartCoroutine (ReadMemory ());
	}

	// Save lists
	IEnumerator WriteMemory (){
		while (true){
			print ("Writing");
			// Wait for the end of the frame to loop again
			yield return null;
		}
	}

	// Load lastest save
	IEnumerator ReadMemory (){
		while (true){
			print ("Reading");
			// Wait for the end of the frame to loop again
			yield return null;
		}
	}

//	void Update(){
//		if (Input.GetKeyDown(KeyCode.Space)){
//			ChangeColor();
//		}
//	}
//			// Random Color & Freeze RigidBody
//			void ChangeColor(){
//		for (int i = 0; i < listBalle.Count; i++) {
//			bool randomColor = Random.Range (0f, 100f) > 20f;
//			if (randomColor == true) {
//				listBalle [i].GetComponent<Renderer> ().material.color = Color.gray;
//				listBalle [i].GetComponent<Rigidbody> ().isKinematic = false;
//			} else {
//				listBalle [i].GetComponent<Renderer> ().material.color = Color.black;
//				listBalle [i].GetComponent<Rigidbody> ().isKinematic = true;
//			}
//		}
//	}

}

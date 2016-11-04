using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour {
	// Variables
	public GameObject laBall;
	public List<GameObject> listBall = new List<GameObject>();
	public List<List<Rewind>> memory = new List<List<Rewind>>();

	public class Rewind{
		public Vector3 position;
		public Vector3 velocity;
		public Rewind(Vector3 _position, Vector3 _velocity){
			position = _position;
			velocity = _velocity;
			}
	}

	// Use this for initialization
	void Start () {

		Writing ();
		
		// Ball Spawn
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				for (int k = 0; k < 10; k++) {
					listBall.Add (Instantiate(laBall, new Vector3(i,j,k), Quaternion.identity)as GameObject);
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
			print ("Writing " + memory.Count);
			// 0
			// Create every balls' position & velocity list
			List<Rewind> listRewind = new List<Rewind> ();
			for (int i = 0; i < listBall.Count; i++) {
				Vector3 position = listBall [i].transform.position;
				Vector3 velocity = listBall [i].GetComponent<Rigidbody>().velocity;
				listRewind.Add (new Rewind (position, velocity));
			}
			// yolo 1000
			// Add to frame ALL informations
			memory.Add (listRewind);
			// Wait for the end of the frame to loop again
			yield return null;
		}
	}

	// Load lastest save
	IEnumerator ReadMemory (){
		while (true){
			print ("Reading");
			List<Rewind> listRewind = memory [memory.Count - 1];
			for (int i = 0; i < listBall.Count; i++) {
				listBall [i].transform.position = listRewind [i].position;
				listBall [i].GetComponent<Rigidbody>().velocity = listRewind [i].velocity;
			}
			memory.RemoveAt (memory.Count - 1);
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
//		for (int i = 0; i < listBall.Count; i++) {
//			bool randomColor = Random.Range (0f, 100f) > 20f;
//			if (randomColor == true) {
//				listBall [i].GetComponent<Renderer> ().material.color = Color.gray;
//				listBall [i].GetComponent<Rigidbody> ().isKinematic = false;
//			} else {
//				listBall [i].GetComponent<Renderer> ().material.color = Color.black;
//				listBall [i].GetComponent<Rigidbody> ().isKinematic = true;
//			}
//		}
//	}

}

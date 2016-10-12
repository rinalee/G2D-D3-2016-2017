using UnityEngine;
using System.Collections;

public class Perso : MonoBehaviour {
	public float speed = 10f;

	void Start(){
		Save.Load ();
	}

	// Update is called once per frame
	void Update () {
		float f = Input.GetAxis ("Horizontal");	//Save Horizontal Pos
		GetComponent<Transform>().Translate(Vector3.right * f * Time.deltaTime * speed);	//Translate

		if (Input.GetKeyDown (KeyCode.Space)) {
			SaveAction ();
		}
	}

	void SaveAction (){
		Save.DoSave (GetComponent<Transform>().position);	// Get Character Position & Calls Save.cs function


	}
}

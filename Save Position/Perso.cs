using UnityEngine;
using System.Collections;

public class Perso : MonoBehaviour {
	public float speed = 10f;	// Player Speed

	void Start(){
		GetComponent<Transform>().position = Save.LoadPosition ();	// Calls for lastest saved position
		GetComponent<Renderer>().material.color = Save.LoadColor ();	// Calls for lastest saved color
	}

	void Update () {
		float f = Input.GetAxis ("Horizontal");	// Save Horizontal Pos
		GetComponent<Transform>().Translate(Vector3.right * f * Time.deltaTime * speed);	// Translate

		if (Input.GetKeyDown (KeyCode.Space)) {
			Save.DoSave (GetComponent<Transform>().position, GetComponent<Renderer>().material.color);	// Get Character Position & Calls Save.cs function
		}
		
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Save.DeleteAllKeys ();
		}
		if (Input.GetKey (KeyCode.C)) {
			GetComponent<Renderer> ().material.color = Random.ColorHSV(0f, 1f, 0f, 1f, 0.5f, 1f);
		}
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour {

	public GameObject laBalle;
	public List<GameObject> listBalle;

	// Use this for initialization
	void Start () {
		listBalle = new List<GameObject>();
		// LOOP
		for (int i = 0; i < 15; i++) {
			for (int j = 0; j < 15; j++) {
				for (int k = 0; k < 15; k++) {
					listBalle.Add (Instantiate(laBalle, new Vector3(i,j,k), Quaternion.identity)as GameObject);
				}
			}
		}
	}

	void Update (){
		if (Input.GetKeyDown(KeyCode.Space)){
			ChangeColor();
		}
	}

	void ChangeColor(){
		for (int i = 0; i < listBalle.Count; i++) {
			listBalle [i].GetComponent<Renderer> ().material.color = Color.gray;
		}
	}
}

using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
	public Transform cube;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 pos = cube.position;
			pos.x += 0.05f;
			cube.position = pos;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 pos = cube.position;
			pos.x -= 0.05f;
			cube.position = pos;
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 pos = cube.position;
			pos.y += 0.05f;
			cube.position = pos;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			Vector3 pos = cube.position;
			pos.y -= 0.05f;
			cube.position = pos;
		}
	}
}

using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	public float speed = 50f;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			transform.Rotate (Vector3.up, speed * Time.deltaTime);
		}
		else {
			transform.Rotate (Vector3.down, speed * Time.deltaTime);
		}
	}
}

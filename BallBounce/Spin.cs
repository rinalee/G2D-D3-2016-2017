using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	public float speed = 50f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, speed * Time.deltaTime);
	}
}

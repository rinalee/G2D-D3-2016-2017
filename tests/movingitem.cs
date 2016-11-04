using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed = 5f;
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.back * Time.deltaTime * speed);
	
	}
}

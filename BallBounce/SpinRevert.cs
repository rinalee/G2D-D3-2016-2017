using UnityEngine;
using System.Collections;

public class SpinRevert : MonoBehaviour {

	public float speed = 50f;

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.down, speed * Time.deltaTime);
	}
}

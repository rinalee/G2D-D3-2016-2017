using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject focusPoint;
	public float speedCam = 1f;
	
	// Update is called once per frame
	void Update () {
		Vector3 v = focusPoint.GetComponent<Transform> ().position;	// Get Focus Position
		GetComponent<Transform>().position = Vector3.Lerp(GetComponent<Transform>().position, v, Time.deltaTime * speedCam);
	}
}

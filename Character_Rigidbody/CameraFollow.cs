using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject focusPoint;
	public float speedCam = 1f;
	public float distanceZ = -10f;
	
	// Update is called once per frame
	void Update () {
		Vector3 v = focusPoint.GetComponent<Transform> ().position;	// Get Focus Position
		v.z = distanceZ;
		Vector3 v2 = GetComponent<Transform>().position;	// Get Camera Position
		GetComponent<Transform>().position = Vector3.Lerp(v2, v, Time.deltaTime * speedCam);
	}
}

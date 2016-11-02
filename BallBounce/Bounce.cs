using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject laBalle;

	// Use this for initialization
	void Start () {
		// LOOP
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				for (int k = 0; k < 10; k++) {
					Instantiate(laBalle, new Vector3(i,j,k), Quaternion.identity);
				}
			}
		}
	}
}

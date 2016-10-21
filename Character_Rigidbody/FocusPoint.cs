using UnityEngine;
using System.Collections;

public class FocusPoint : MonoBehaviour {
	public GameObject target;	// Focus' Target
	public GameObject player;	// Player's GameObject

	// Use this for initialization
	void Start () {
		target = player;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Transform> ().position = target.GetComponent<Transform> ().position;
	}
}

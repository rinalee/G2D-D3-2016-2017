using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	
	public GameObject Bullet;
	private Coroutine c;

	void Update() {
		RotateGun ();
		if (Input.GetMouseButtonDown (0)) {
			c = StartCoroutine (SpawnBullet ());
		}
		if (Input.GetMouseButtonUp (0)) {
			StopCoroutine(c);
		}
	}

		void RotateGun (){
		float f = Input.GetAxis ("Vertical");
		GetComponent<Transform> ().Rotate (Vector3.forward * f);
	}

		IEnumerator SpawnBullet(){
			while (true){
				Instantiate (Bullet,GetComponent<Transform>().position,GetComponent<Transform>().rotation);
			yield return new WaitForSeconds (0.1f);
		}
	}
}
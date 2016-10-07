using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody r = GetComponent<Rigidbody> ();	//Get Bullet RigidBody
		r.AddRelativeForce(Vector3.right * 1000f);	//Add force to Bullet
		StartCoroutine(DestroyBuullet());
	}
	IEnumerator DestroyBuullet(){
		yield return new WaitForSeconds (3f);
		Destroy (this.gameObject);
	}

}

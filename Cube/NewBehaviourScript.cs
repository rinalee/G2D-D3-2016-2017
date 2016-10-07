using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public Transform cube;
	bool myBool = true;
	int myInt;
	string myString;
	float myFloat;
	int timer;
	int timerMax = 5;
	Vector2 myVector2;
	Vector3 myVector3;
	Vector4 myVector4;
	GameObject myGameObject;
	UICharInfo myUICharInfo;
	UILineInfo myUILineInfo;
	AnimatorStateInfo myAnimStateInfo01;
	UIVertex myUIVertex;


	void Awake (){
		print (myInt);
		print ("Blablabla");
	}

	void Start () {
		StartCoroutine (TestCoroutine ());
	}

	IEnumerator TestCoroutine(){
		while (true) {
//			print (Time.time);
//			yield return new WaitForSeconds(1);
			timer =+1;
			print (timer);
			yield return new WaitForSeconds (1);
			timer =+1;
			print (timer);
			yield return new WaitForSeconds (1);
			timer =+1;
			print (timer);
			yield return new WaitForSeconds (1);
			timer =+1;
			print (timer);
			yield return new WaitForSeconds (1);
			timer =+1;
			print (timer);
			yield return new WaitForSeconds (1);
		}

		if (timer==timerMax) {
			yield return new WaitForSeconds (1);
			timer = 0;
			print (timer);
		}

	}

	void Update () {


		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 pos = cube.position;
			pos.x += 0.05f;
			cube.position = pos;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 pos = cube.position;
			pos.x -= 0.05f;
			cube.position = pos;
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 pos = cube.position;
			pos.y += 0.05f;
			cube.position = pos;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			Vector3 pos = cube.position;
			pos.y -= 0.05f;
			cube.position = pos;
		}

		if (Input.GetKeyDown (KeyCode.Tab)) {
			MyMethod ();
		}
		else if (Input.GetKeyUp (KeyCode.Tab)) {
			MyMethod2 ();
		}
	}

	void MyMethod () {
		myInt = 30;
		print (myInt);
	}

	void MyMethod2 () {
		myInt = 15;
		print (myInt);
	}
}
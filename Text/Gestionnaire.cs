using UnityEngine;
using System.Collections;

public class Gestionnaire : MonoBehaviour {

//	int compteur = 0;
	Stats stat;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			InitStat ();
		}
		if (Input.GetKeyDown (KeyCode.Return)) {
			ChangeName ();
		}
	}
		
	void InitStat(){
		stat = new Stats(13546,9782,47,3435435,"Acerolaorion",new Vector3(1,2,3));
	}

	void ChangeName(){
		stat.SetName ("Heartunderblade");
	}
}

using UnityEngine;
using System.Collections;

public class Stats{
//	public ImprimerText(string message){
//	public ImprimerText(){
//		Debug.Log (variableImpr);
//		Debug.Log (message);
//	}

	int hp;
	int mp;
	int level;
	int xp;
	string name;
	Vector3 position;

	public Stats(int hp2, int mp2, int level2, int xp2, string name2, Vector3 position2){

		hp = hp2;
		mp = mp2;
		level = level2;
		xp = xp2;
		name = name2;
		position = position2;

		Debug.Log ("HP : " + hp + " MP : " + mp + " Level : " + level + " XP : " + xp + "/10000000" + " Name : " + name);	
	}

	public void SetName(string newName){
		name = newName;
		Debug.Log("New Name = " + name);
	}
}
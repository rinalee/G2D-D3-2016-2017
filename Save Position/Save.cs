using UnityEngine;
using System.Collections;

public class Save {
	
	public static Vector3 LoadPosition(){	// Load Position & Sends back to Vector3
		float x = PlayerPrefs.GetFloat ("posX");
		float y = PlayerPrefs.GetFloat ("posY");
		float z = PlayerPrefs.GetFloat ("posZ");
		Debug.Log ("Load " + x, y, z);	//Shows loaded position in Debug Log
		return new Vector3 (x, y, z);
	}
	
	public static Color LoadColor(){
		float r = PlayerPrefs.GetFloat ("ColorR");
		float g = PlayerPrefs.GetFloat ("ColorG");
		float b = PlayerPrefs.GetFloat ("ColorB");
		float a = PlayerPrefs.GetFloat ("ColorA");
		Debug.Log ("Loaded R : " + r + " Loaded G : " + g + " Loaded B : " + b + " Loaded A : " + a);	//Shows loaded position in Debug Log
		return new Color (r,g,b,a);
	}

	public static void DoSave(Vector3 positionPlayer){	// Save Position & Color
		// Position
		PlayerPrefs.SetFloat ("posX", positionPlayer.x);
		PlayerPrefs.SetFloat ("posY", positionPlayer.y);
		PlayerPrefs.SetFloat ("posZ", positionPlayer.z);
		
		// Color
		PlayerPrefs.SetFloat ("ColorR", color.r);
		PlayerPrefs.SetFloat ("ColorG", color.g);
		PlayerPrefs.SetFloat ("ColorB", color.b);
		PlayerPrefs.SetFloat ("ColorA", color.a);
		
		Debug.Log ("Saved X : " + PlayerPrefs.GetFloat("posX") + " Saved Y : " + PlayerPrefs.GetFloat("posY") + " Saved Z : " + PlayerPrefs.GetFloat("posZ"));	// Show Saved Position in Debug Log
	}
	
	public static void DeleteAllKeys(){
		PlayerPrefs.DeleteAll();
	}
}

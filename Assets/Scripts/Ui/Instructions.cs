using UnityEngine;
using System.Collections;
//Dylan Waij

public class Instructions : MonoBehaviour {

	public GUISkin guiskin;

	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.32f, Screen.height * 0.08f, 575, 575), "Instructions");
		GUI.Label (new Rect (Screen.width * 0.42f,Screen.height * 0.21f,Screen.width * 0.2f,Screen.height * 0.1f), " - ");
		GUI.Label (new Rect (Screen.width * 0.42f, Screen.height * 0.27f, Screen.width * 0.2f, Screen.height * 0.1f), " - ");
		GUI.Label (new Rect (Screen.width * 0.42f, Screen.height * 0.33f, Screen.width * 0.2f, Screen.height * 0.1f), " - ");
		if (GUI.Button (new Rect (Screen.width * 0.42f, Screen.height * 0.7f, Screen.width * 0.2f, Screen.height * 0.1f), "Main Menu")) {
			Application.LoadLevel ("MainMenu");
		}
		
	}
}

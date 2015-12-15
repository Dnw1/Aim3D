using UnityEngine;
using System.Collections;
//Dylan Waij

public class MainMenu : MonoBehaviour {
		
	public GUISkin guiskin;
	
	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.32f, Screen.height * 0.08f, 575, 575), "Main Menu: -");
		
		if(GUI.Button(new Rect(Screen.width * 0.42f,Screen.height * 0.35f,Screen.width * 0.2f,Screen.height * 0.1f), "Play")){
			Application.LoadLevel("main");
		}   //Scene is de scene van de game.
		if (GUI.Button (new Rect (Screen.width * 0.42f, Screen.height * 0.5f, Screen.width * 0.2f, Screen.height * 0.1f), "Credits")) {
			Application.LoadLevel("Credits");
		}
		if (GUI.Button (new Rect (Screen.width * 0.42f, Screen.height * 0.65f, Screen.width * 0.2f, Screen.height * 0.1f), "Instructions")) {
			Application.LoadLevel("Instructions");
		}
	}
}
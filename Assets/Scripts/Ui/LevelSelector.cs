using UnityEngine;
using System.Collections;

public class LevelSelector : MonoBehaviour {

	public GUISkin guiskin;
	
	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.33f, Screen.height * 0.08f, 575, 575), "Level Selector:");
		
		if(GUI.Button(new Rect(Screen.width * 0.42f,Screen.height * 0.35f,Screen.width * 0.2f,Screen.height * 0.1f), "Tutorial")){
			Application.LoadLevel("Tutorial");
		}
		if (GUI.Button (new Rect (Screen.width * 0.42f, Screen.height * 0.5f, Screen.width * 0.2f, Screen.height * 0.1f), "Level 1")) {
			Application.LoadLevel("Level1");
		}
		if (GUI.Button (new Rect (Screen.width * 0.42f, Screen.height * 0.65f, Screen.width * 0.2f, Screen.height * 0.1f), "Level 2")) {
			Application.LoadLevel("Level2");
		}
		if (GUI.Button (new Rect (Screen.width * 0.42f, Screen.height * 0.8f, Screen.width * 0.2f, Screen.height * 0.1f), "Level 3")) {
			Application.LoadLevel("Level3");
		}
     }
}
using UnityEngine;
using System.Collections;
//Dylan Waij

public class Instructions : MonoBehaviour {

	public GUISkin guiskin;

	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.30f, Screen.height * 0.08f, 575, 575), "Instructions");
		GUI.Label (new Rect (Screen.width * 0.42f,Screen.height * 0.21f,Screen.width * 0.2f,Screen.height * 0.1f), "In the game you need to both reach the other side of the room without both dying to traps.");
		GUI.Label (new Rect (Screen.width * 0.42f, Screen.height * 0.27f, Screen.width * 0.2f, Screen.height * 0.1f), "Work together because a timer will be counting down and when it hits 0 you lose automatically.");
		GUI.Label (new Rect (Screen.width * 0.42f, Screen.height * 0.34f, Screen.width * 0.2f, Screen.height * 0.1f), "You can't see the timer which adds to the thrill, you also only have 3 Healthpoints get hit 3 times and your done.");
		GUI.Label (new Rect (Screen.width * 0.42f, Screen.height * 0.41f, Screen.width * 0.2f, Screen.height * 0.1f), "Use A to jump and controls to move camera / player. If you don't have a controller don't worry.");
		GUI.Label (new Rect (Screen.width * 0.42f, Screen.height * 0.47f, Screen.width * 0.2f, Screen.height * 0.1f), "I made a backup which uses wasd and arrow keys P1 uses wasd and Q/E to look around space is jump.");
		GUI.Label (new Rect (Screen.width * 0.42f, Screen.height * 0.53f, Screen.width * 0.2f, Screen.height * 0.1f), "For P2 it is arrow keys and right Ctrl and right Shift to look around and right Enter to jump.");
		if (GUI.Button (new Rect (Screen.width * 0.42f, Screen.height * 0.7f, Screen.width * 0.2f, Screen.height * 0.1f), "Main Menu")) {
			Application.LoadLevel ("MainMenu");
		}
		
	}
}

using UnityEngine;
using System.Collections;

public class TextIntro : MonoBehaviour {

	public string text;
	bool display = false;

	void OnTriggerEnter(Collider col)
	{
		if (col.transform.name == "Player") {
			display = true;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.transform.name == "Player") 
		{
			display = false;
		}
	}

	void OnGUI()
	{
		if (display == true) 
		{
			GUI.Box (new Rect(100,150,Screen.width-200, Screen.height-400), text);
		}
	}
}

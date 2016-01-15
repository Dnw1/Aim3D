using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public bool leftDoor = false;
	public bool rightDoor = false;

	void OnCollisionEnter(Collision col) {
		Debug.Log ("He");

		if (col.gameObject.tag == "Player1") {
			leftDoor = true;
			Debug.Log("hey");
		}
		if(col.gameObject.tag == "Player2") {
			rightDoor = true;
		}
		if(rightDoor == true && leftDoor == true) {
			Application.LoadLevel("LevelSelector");
			leftDoor = false;
		    rightDoor = false;
		}

	 }
}
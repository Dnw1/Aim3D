using UnityEngine;
using System.Collections;

public class BackupMovement : MonoBehaviour {
	
	[SerializeField]private float Speed = 4;
	[SerializeField]private float rotateSpeed;
	[SerializeField]private bool Player1;
	[SerializeField]private bool Player2;
	// Use this for initialization
	void Start () {
		//StartCoroutine (backupCorountine ());
	}
	
	// Update is called once per frame
	void Update () {
		P1Moving ();
		P2Moving ();
		P1Rotate ();
		P2Rotate ();
	}
	public void P1Rotate()
	{if (Player1 == true) {
			//Rotates the player on the Y Axis
			if (Input.GetKey (KeyCode.Q)) {        //Rotates Left
				transform.Rotate (-Vector3.up * Time.deltaTime * rotateSpeed);
			}
			if (Input.GetKey (KeyCode.E)) {       //Rotates Right
				transform.Rotate (Vector3.up * Time.deltaTime * rotateSpeed);
			}
		}
	}
	public void P2Rotate()
	{if (Player2 == true) {
			if (Input.GetKey (KeyCode.RightShift)) {        //Rotates Left
				transform.Rotate (-Vector3.up * Time.deltaTime * rotateSpeed);
			}
			if (Input.GetKey (KeyCode.RightControl)) {       //Rotates Right
				transform.Rotate (Vector3.up * Time.deltaTime * rotateSpeed);
			}
		}
	}
	void P1Moving()
	{if (Player1 == true) {
			if (Input.GetKey (KeyCode.W)) {                 //Walk Forward
				transform.Translate (Vector3.forward * Time.deltaTime * Speed);
			}
			if (Input.GetKey (KeyCode.A)) {                //Walk Left
				transform.Translate (Vector3.left * Time.deltaTime * Speed);
			}
			if (Input.GetKey (KeyCode.S)) {                //Walk Backwards
				transform.Translate (-Vector3.forward * Time.deltaTime * Speed);
			}
			if (Input.GetKey (KeyCode.D)) {                //Walk Right
				transform.Translate (Vector3.right * Time.deltaTime * Speed);
			}
			if (Input.GetKey (KeyCode.Space)) {
				transform.Translate (Vector3.up * Time.deltaTime * 6);
			}
		}
	}
	void P2Moving()
	{if (Player2 == true) {
			if (Input.GetKey (KeyCode.UpArrow)) {                 //Walk Forward
				transform.Translate (Vector3.forward * Time.deltaTime * Speed);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {                //Walk Left
				transform.Translate (Vector3.left * Time.deltaTime * Speed);
			}
		
			if (Input.GetKey (KeyCode.DownArrow)) {                //Walk Backwards
				transform.Translate (-Vector3.forward * Time.deltaTime * Speed);
			}
			if (Input.GetKey (KeyCode.RightArrow)) {                //Walk Right
				transform.Translate (Vector3.right * Time.deltaTime * Speed);
			}
			if (Input.GetKey (KeyCode.KeypadEnter)) {
				transform.Translate (Vector3.up * Time.deltaTime * 6);
			} //I know I'm doing it wrong but I could not think of a better alternative at the time.
		}
	}
}
using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float time = 10f;
	private float limit = 800f;
	private Vector3 currentLocation;

	// Use this for initialization
	void Start () {
		currentLocation = new Vector3 (0,0,0);
		currentLocation = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(limit >= 0){
			limit = limit -1f;
			Debug.Log("Check1");
		}
		timeController ();
	}
	void timeController(){
		if(limit <= 0 || currentLocation != gameObject.transform.position){
			time -= Time.deltaTime;
			Debug.Log("Check2");
		}
		currentLocation = gameObject.transform.position;
		if (time <= 0) {
			Application.LoadLevel("Credits");
		}

	}
}

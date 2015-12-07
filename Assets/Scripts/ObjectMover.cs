using UnityEngine;
using System.Collections;

public class ObjectMover : MonoBehaviour {

	public float TurnSpeed;

	void Update() {
		transform.Rotate(Vector3.right * TurnSpeed);
		transform.Rotate(Vector3.up * TurnSpeed, Space.World);
	}
}
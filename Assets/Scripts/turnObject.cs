using UnityEngine;
using System.Collections;

public class turnObject : MonoBehaviour {

	public float TurnSpeed;
	public float speed = 2.0f; 
	private Vector3 startPos;
	public bool turnRight = false;
	public bool turnLeft = false;

	public float timer1;
	public float maxTime1;
	
	void Start () {
		startPos = transform.position;
	}
	
	void Update () {
		StartCoroutine (Turn ());
	}
	void Turning()
	{
		if (turnRight == true) {
			transform.Rotate (Vector3.right * TurnSpeed);
		} if (turnLeft == true) {
			transform.Rotate (Vector3.left * TurnSpeed);
		}

		//transform.Rotate(Vector3.up * TurnSpeed, Space.World);
	}
	IEnumerator Turn()
	{
		if (timer1 < maxTime1) 
		{
			Turning();
			timer1 = timer1 +1;
		} 
		if (timer1 >= maxTime1) {
			yield return new WaitForSeconds(0.01f);
			timer1 = timer1 = 0;
		}
	}
}
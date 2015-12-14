using UnityEngine;
using System.Collections;

public class backAndForth : MonoBehaviour {

	public float delta = 1.5f;  // Amount to move left and right from the start point
	public float speed = 2.0f;
	public bool zposition = false;
	public bool xposition = false;
	public bool yposition = false;
	private Vector3 startPos;

	public float timer2;
	public float maxTime2;
	
	void Start () {
		startPos = transform.position;
	}
	
	void Update () {
		StartCoroutine (move ());
	}
	void mover()
	{
		Vector3 pos = startPos;
		if (zposition == true) {
			pos.z += delta * Mathf.Sin (Time.time * speed);
		} if (xposition == true) {
			pos.x += delta * Mathf.Sin (Time.time * speed);
		} if (yposition == true) {
			pos.y += delta * Mathf.Sin (Time.time * speed);
		}
		transform.position = pos;
	}
    IEnumerator move()
    {
    if (timer2 < maxTime2) 
	{
		mover();
		timer2 = timer2 +1;
	} 
	if (timer2 >= maxTime2) {
		yield return new WaitForSeconds(0.01f);
		timer2 = timer2 = 0;
	}
    }
}

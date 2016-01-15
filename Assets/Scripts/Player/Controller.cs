using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	private ControllerInput _input;        //Input Class import
	//Speed
	[SerializeField]private float movementSpeed;
	[SerializeField]private float rotationSpeed;

	private bool canJump;      //checks if player can jump
	private bool isGrounded;   //Checks if player is on the ground

	void Start()
	{
		_input      = GetComponent<ControllerInput>();
	}
	
	void Update()
	{
		Movement();
		Rotation();
	}
	public void Rotation()
	{
		//Rotates the player on the Y Axis
		if (_input._rsLeft)        //Rotates Left
		{
			transform.Rotate(-Vector3.up * Time.deltaTime * rotationSpeed);
		}
		if (_input._rsRight)       //Rotates Right
		{
			transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
		}
	}
	
	public void Movement()
	{
		if (_input._lsUp)       //Moves forward
		{
			transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
		}
		if (_input._lsDown)     //Moves backward (Backpeddling)
		{
			transform.Translate(-Vector3.forward * Time.deltaTime * movementSpeed / 2f);   //Backpeddling has decreased movement speed
		}
		if (_input._lsRight)    //Moves right (strafe)
		{
			transform.Translate(-Vector3.left * Time.deltaTime * movementSpeed);
		}
		if (_input._lsLeft)     //Moves left (strafe)
		{
			transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
		}
		if (_input._aPressed || canJump == true) {
			transform.Translate(Vector3.up * Time.deltaTime * 6);
		}
	}

}

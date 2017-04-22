//Rollerball Unity Tutorial Modification
//LMSC-281 Spring 2017

using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveVertical = Input.GetAxis ("Vertical");

		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}
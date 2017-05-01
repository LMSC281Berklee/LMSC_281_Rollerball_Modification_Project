//Rollerball Unity Tutorial Modification
//LMSC-281 Spring 2017

using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


	public float speed;
	public Vector3 jump;
	public float jumpForce = 2.0f;

	public bool onGround;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		jump = new Vector3 (0, 2f, 0);
	}

	void OnCollisionStay()
	{
		onGround = true;
	}

	void FixedUpdate ()
	{
		float moveVertical = Input.GetAxis ("Vertical");

		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

		if (Input.GetKeyDown (KeyCode.Space) && onGround)
		{
			rb.AddForce (jump * jumpForce, ForceMode.Impulse);
			onGround = false;
		}
	}
}

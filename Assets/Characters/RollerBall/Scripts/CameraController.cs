//Rollerball Unity Tutorial Modification
//LMSC-281 Spring 2017
//referred Unity Forum

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float turnSpeed = 5.0f;
	public Transform player;

	public float height = 2f;
	public float distance = 3f;

	private Vector3 offsetX;
	private Vector3 offsetY;

	void Start ()
	{
		offsetX = new Vector3 (0, height, distance);
		offsetY = new Vector3 (0, 0, distance);
	}

	void LateUpdate ()
	{
		offsetX = Quaternion.AngleAxis (Input.GetAxis ("Mouse X") * turnSpeed, Vector3.up) * offsetX;
		offsetY = Quaternion.AngleAxis (Input.GetAxis ("Mouse Y") * turnSpeed, Vector3.right) * offsetY;
		transform.position = player.position + offsetX;
		transform.LookAt (player.position);
	}
}

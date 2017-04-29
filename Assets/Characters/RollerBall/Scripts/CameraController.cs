//Rollerball Unity Tutorial Modification
//LMSC-281 Spring 2017

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public string timer; 
	public float timedown;
	public Text counttext;

	private Vector3 offset;

	void Start ()
	{

		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		counttext.text = timer;
		timer = timedown.ToString();
		transform.position = player.transform.position + offset;
		timedown = 30 - Time.fixedTime;
		if (timedown <= 0) 
		{player.gameObject.SetActive(false);
			timer="GAMEOVER";}
	}
}
//LMSC 281
//Augustus Rivera
//Roller Ball Mos
//Time Manager Script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour {

	public static float timer;
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
		timer = 5f;

	}

	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		text.text = "Timer: " + Mathf.RoundToInt(timer);


	}

	void RestartCurrentScene()
	{
		if (Time.deltaTime >= 5f) 
		{
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}


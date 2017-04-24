// Kenny Harmon
// LMSC-281
// Roller Ball Edit Assignment
// Timer Mgmt Script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour 
{

	public static float timer; 						// float because Time.deltaTime is a float

	Text text;

	void Awake()
	{
		text = GetComponent<Text>();
		timer = 20;
	}

	void Update()
	{
		timer -= Time.deltaTime; 					// subtract seconds of runtime from counter
		setTimer(Mathf.RoundToInt(timer));			// round the float timer result and display

		if (timer <= 0)								// disallow negative time
		{
			setTimer(0);							// change later to trigger game end sequence
		}
	}

	void setTimer(int time)	
	{
		text.text = "Timer: " + time;
	}
}

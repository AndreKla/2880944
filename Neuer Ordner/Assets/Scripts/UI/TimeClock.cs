using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeClock : MonoBehaviour {

	public Text time;
	int seconds,minutes,hours;

	void Start () {
		hours = 15;
		minutes = 0;
		time.text = "15:00";
	}
	
	void Update () {

		seconds++;
		if (seconds == 1000) {
			seconds = 0;
			minutes++;
			if(minutes == 60){
				minutes = 0;
				hours++;
			}
		}
		if (minutes <= 9) {
			time.text = hours.ToString () + ": 0" + minutes.ToString ();

		} else {
			time.text = hours.ToString () + ":" + minutes.ToString ();

		}

	}
}

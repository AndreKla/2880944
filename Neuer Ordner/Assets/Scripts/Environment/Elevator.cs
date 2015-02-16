using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {

	bool up = false;
	int counter = 0;
	Vector3 start;
	Vector3 destination;

	void Start () {

		start = this.gameObject.transform.position;
		destination = new Vector3 (this.transform.position.x, this.transform.position.y + 2f, this.transform.position.z);
	}
	
	void Update () {

		counter++;
		//print (counter.ToString ());

		if (up && counter >= 150) {

			iTween.MoveTo (this.gameObject,iTween.Hash ("y",start.y,"time",2f));
			print ("oben");
			counter = 0;
			up = false;
				
		} else {
				
			iTween.MoveTo (this.gameObject,iTween.Hash ("y",destination.y,"time",2f));
			print ("unten");
			up = true;
		}
	
	}
}

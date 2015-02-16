using UnityEngine;
using System.Collections;

public class ColTrig : MonoBehaviour {

	public GameObject obj;

	void OnTriggerEnter(Collider other){

		print ("drin");
		print ("bin drin und name . " + other.ToString ());
		obj.GetComponent<Escalator> ().hit = true;
	}

	void OnTriggerExit(Collider other){

		print ("bint raus loo");
		obj.GetComponent<Escalator> ().hit = false;

	}
}

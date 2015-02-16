using UnityEngine;
using System.Collections;

public class DepatureBoard : MonoBehaviour {

	public GameObject camera;
	public GameObject mainCamera;
	bool clicked = false;

	void OnMouseDown(){

		if (!clicked) {
			mainCamera.gameObject.SetActive (false);
			camera.SetActive (true);	
			clicked = true;
		} else {
		
			mainCamera.gameObject.SetActive (true);
			camera.SetActive (false);	
			clicked = false;
		}

	}
}

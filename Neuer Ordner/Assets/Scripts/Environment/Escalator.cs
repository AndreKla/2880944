using UnityEngine;
using System.Collections;

public class Escalator : MonoBehaviour {

	public GameObject player;
	public bool up;
	public bool hit;

	void OnMouseDown(){

		print ("hab geklickt looo");
		
		//player.GetComponent<Animatorio> ().walk = false;
		if (up) {
			//player.GetComponent<Animatorio>().walkTo ();
			if(hit){
				player.GetComponent<Animatorio>().enabled = false;
				iTween.MoveTo (player,iTween.Hash ("x",15f,"y",15.18f,"time",8f));
			}

			//player.GetComponent<Animatorio> ().walk = true;

		} 
		else {
			///iTween.MoveTo (player,iTween.Hash ("x",,"y",,"time",3f);

		}

	}
}

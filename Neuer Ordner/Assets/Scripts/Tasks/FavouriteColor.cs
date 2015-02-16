using UnityEngine;
using System.Collections;

public class FavouriteColor : MonoBehaviour {
	
	public void ChoosenTieColor(string color){

		PlayerPrefs.SetString ("color", color);
		PlayerPrefs.Save ();
		//Application.LoadLevel ("nextLevel");
	}
}

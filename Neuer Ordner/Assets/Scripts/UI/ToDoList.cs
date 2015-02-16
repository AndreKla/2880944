using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToDoList : MonoBehaviour {

	public Image todolist;
	bool clicked = false;

	public void ShowBig(){

		if (!clicked) {

			todolist.rectTransform.anchoredPosition = new Vector2(0,22);
			todolist.rectTransform.sizeDelta = new Vector2( 400, 400); 
			clicked = true;

		} else {
			todolist.rectTransform.anchoredPosition = new Vector2(361,-183);
			todolist.rectTransform.sizeDelta = new Vector2( 100, 100); 
			clicked = false;		
		}

	}


}

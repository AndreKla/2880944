using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Globalization;
using System;

public class Intro_Data : MonoBehaviour {

	public Text firstNameText;
	public Text surNameText;

	public InputField fN;
	public InputField sN;

	public Button male;
	public Text maleButtonText;
	public Button female;
	public Text femaleButtonText;

	public Text sizeText;

	public Image imagePassport;
	public Sprite femaleImage;
	public Sprite maleImage;

	string firstname, secondname, gender, sizeString, eyecolor;

	public Text birthDay;
	public Text birthMonth;
	public Text birthYear;
	string dayString,monthString,yearString;
	int size,day,month,year;

	int count = 0;


	void Update () {

		firstname = firstNameText.text;
		secondname = surNameText.text;
		sizeString = sizeText.text; 
		dayString = birthDay.text;
		monthString = birthMonth.text;
		yearString = birthYear.text;

		/*
		if(Input.GetKey(KeyCode.Tab)){

			count++;
			print (count);
		}

		if(count == 1){
			fN.ActivateInputField ();
			
		}
		if(count == 2){
			sN.ActivateInputField();
			count = 0;
		}*/
	}
	

	public void InitializePlayer(){

		size = int.Parse (sizeString);
		day = int.Parse (dayString);
		month = int.Parse (monthString);
		year = int.Parse (yearString);

		DateTime birthDate = new DateTime (year, month, day);	

		PlayerPrefs.SetInt ("birthDay", day);
		PlayerPrefs.SetInt ("birthMonth", month);

		Player player = new Player (firstname,secondname,birthDate,gender,size);
		PlayerPrefs.Save ();
	}

	public void MaleButtonClicked(){

		maleButtonText.text = "X";
		femaleButtonText.text = " ";
		gender = "Male";
		imagePassport.GetComponent<Image> ().sprite = maleImage;

	}

	public void FemaleButtonClicked(){

		maleButtonText.text = "";
		femaleButtonText.text = "X";
		gender = "Female";
		imagePassport.GetComponent<Image> ().sprite = femaleImage;

	}

}

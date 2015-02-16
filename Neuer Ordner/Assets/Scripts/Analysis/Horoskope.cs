using UnityEngine;
using System.Collections;
using System;

public class Horoskope : MonoBehaviour {

	string birthDate,birthDay,birthMonth;
	int day,month;

	void Start () {

		day = PlayerPrefs.GetInt ("birthDay");
		month = PlayerPrefs.GetInt ("birthMonth");

		if (day >= 21 && day <= 31 && month == 1 || day <= 19 && month == 2) {
			print ("sternzeichen: Wassermann von 21.01 - 19.02 akt Dat: " + day + " " + month);
		}
		if (day >= 20 && day <= 30 && month == 2 || day <= 20 && month == 3) {
			print ("sternzeichen: Fische von 20.02 - 20.03 akt Dat: " + day + " " + month);
		}
		if (day >= 21 && day <= 31 && month == 3 || day <= 20 && month == 4) {
			print ("sternzeichen: Widder von 21.03 - 20.04 akt Dat: " + day + " " + month);
		}
		if (day >= 21 && day <= 31 && month == 4 || day <= 20 && month == 5) {
			print ("sternzeichen: Stier von 21.04 - 20.05 akt Dat: " + day + " " + month);
		}
		if (day >= 21 && day <= 31 && month == 5 || day <= 21 && month == 6) {
			print ("sternzeichen: Zwillinge von 21.08 - 21.06 akt Dat: " + day + " " + month);
		}
		if (day >= 22 && day <= 31 && month == 6 || day <= 22 && month == 7) {
			print ("sternzeichen: Krebs von 22.06 - 22.07 akt Dat: " + day + " " + month);
		}
		if (day >= 23 && day <= 31 && month == 7 || day <= 23 && month == 8) {
			print ("sternzeichen: löwe von 23.07 - 23.08 akt Dat: " + day + " " + month);
		}	
		if (day >= 24 && day <= 31 && month == 8 || day <= 23 && month == 9) {
			print ("sternzeichen: jungfrau von 24.08 - 23.09 akt Dat: " + day + " " + month);
		}
		if (day >= 24 && day <= 31 && month == 9 || day <= 23 && month == 10) {
			print ("sternzeichen: waage von 24.09 - 23.10 akt Dat: " + day + " " + month);
		}
		if(day >= 24 && day <= 31 && month == 10 || day <= 22 && month == 11){
			print ("sternzeichen: scorpion von 24.10 - 22.11 akt Dat: " + day + " " + month);
		}
		if (day >= 23 && day <= 31 && month == 11 || day <= 21 && month == 12) {
			print ("sternzeichen: schütze von 23.11 - 21.12 akt Dat: " + day + " " + month);
		}
		if (day >= 22 && day <= 31 && month == 12 || day <= 20 && month == 1) {
			print ("sternzeichen: schütze von 22.12 - 20.01 akt Dat: " + day + " " + month);
		}
	}

}

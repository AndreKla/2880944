using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InteractionDialog : MonoBehaviour {

	public GameObject dialogScript;
	public GameObject dialog;
	public Image foto;
	public Sprite personFoto;
	public Text text;
	public string textText;
	//public Button btnnn1;
	GameObject player;

	public Button btn1, btn2, btn3, btn4;
	public float val1,val2,val3,val4;
	public int btn1Num,btn2Num,btn3Num,btn4Num;

	void OnMouseDown(){

		player = GameObject.Find ("makehuman");
		player.GetComponent<Animatorio> ().enabled = false;

		dialog.SetActive (true);
		foto.sprite = personFoto;
		text.text = dialogScript.GetComponent<Dialog>().dialog1Human[0];
		btn1.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[1];		
		btn2.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[2];
		btn3.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[3];
		btn4.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[4];

		btn1.onClick.AddListener (() => { SetButtonMethod(btn1,btn1Num,val1);});
		btn2.onClick.AddListener (() => { SetButtonMethod(btn2,btn2Num,val2);});
		btn3.onClick.AddListener (() => { SetButtonMethod(btn3,btn3Num,val3);});
		btn4.onClick.AddListener (() => { SetButtonMethod(btn4,btn4Num,val4);});

	}
	
	public void SetButtonMethod(Button btn,int num,float val){

		switch (num) {
				
		case 0:
			break;
		case 1:
			btn.onClick.AddListener (() => { Neuroticism(val); ClickedBtn1();});
			break;
		case 2:
			btn.onClick.AddListener (() => { Extraversion(val); ClickedBtn2();});
			break;
		case 3:
			btn.onClick.AddListener (() => { Openness(val);ClickedBtn3();});
			break;
		case 4:
			btn.onClick.AddListener (() => { Conscientiousness(val); ClickedBtn4();});
			break;
		case 5:
			btn.onClick.AddListener (() => { Agreeableness(val);ClickedBtn2();});
			break;

		}

	}

		//Set Methods
	public void Neuroticism(float amount){

		print ("deine mutter");

		float temp = PlayerPrefs.GetFloat ("neuroticism");
		temp += amount;
		PlayerPrefs.SetFloat ("neuroticism", temp);
	}
	
	public void Extraversion(float amount){
			
		float temp = PlayerPrefs.GetFloat ("extraversion");
		temp += amount;
		PlayerPrefs.SetFloat ("extraversion", temp);
	}

	public void Openness(float amount){

		
		float temp = PlayerPrefs.GetFloat ("openness");
		temp += amount;
		PlayerPrefs.SetFloat ("openness", temp);
	}

	public void Conscientiousness(float amount){
		
		float temp = PlayerPrefs.GetFloat ("conscientiousness");
		temp += amount;
		PlayerPrefs.SetFloat ("conscientiousness", temp);
	}

	public void Agreeableness(float amount){
		
		float temp = PlayerPrefs.GetFloat ("agreeableness");
		temp += amount;
		PlayerPrefs.SetFloat ("agreeableness", temp);
	}


	public void ClickedBtn1(){
		
		text.text = dialogScript.GetComponent<Dialog>().dialog1Human[5];
		btn1.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[6];		
		btn2.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[7];
		btn3.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[8];
		btn4.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[9];

		btn2.onClick.AddListener (() => { Continue ();});

	}

	public void ClickedBtn2(){
		
		text.text = dialogScript.GetComponent<Dialog>().dialog1Human[10];
		btn1.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[11];		
		btn2.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[12];
		btn3.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[13];
		btn4.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[14];

	}

	public void ClickedBtn3(){
		
		text.text = dialogScript.GetComponent<Dialog>().dialog1Human[15];
		btn1.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[16];		
		btn2.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[17];
		btn3.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[18];
		btn4.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[19];

	}

	public void ClickedBtn4(){
		
		text.text = dialogScript.GetComponent<Dialog>().dialog1Human[20];
		btn1.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[21];		
		btn2.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[22];
		btn3.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[23];
		btn4.GetComponentInChildren<Text> ().text = dialogScript.GetComponent<Dialog>().dialog1Human[24];


	}

	public void Continue(){

		player.GetComponent<Animatorio> ().enabled = true;
		dialog.SetActive (false);

	}
	
}

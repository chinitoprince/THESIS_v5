using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Register : MonoBehaviour {

	public Text  inputusername  ;
	public Text inputpassword  ;
	public Text inputsection ;
	public Text inputadviser ;
	public Text inputaddress ;
	public Text inputmonth;
	public Text inputday;
	public Text inputyear;
	public string inputusername1;
	public string inputpassword1;
	public string inputsection1;
	public string inputadviser1;
	public string inputaddress1;
	public string Dob;
	string LoginURL = "localhost/thesis/Register.php";


	// Use this for initialization
	//void Start () {

	//}
	public void REGISTER()
	{
		inputusername1 = inputusername.text;
		inputpassword1 = inputpassword.text;
		inputsection1 = inputsection.text;
		inputadviser1 = inputadviser.text;
		inputaddress1 = inputaddress.text;
		Dob = inputmonth.text + " " + inputday.text + "," + inputyear.text;
		//if (Input.GetKeyDown (KeyCode.KeypadEnter))
			StartCoroutine(RegisterToDB (inputusername1, inputpassword1, inputsection1, inputadviser1, inputaddress1, Dob));
		

	}
	// Update is called once per frame
	//void Update () {
		
	//}

	IEnumerator RegisterToDB(string Username, string Password, string Section, string Adviser, string Address, string Dob){
		WWWForm form = new WWWForm ();
		form.AddField("UsernamePost", Username);
		form.AddField("PasswordPost", Password);
		form.AddField("SectionPost", Section);
		form.AddField("AdviserPost", Adviser);
		form.AddField("AddressPost", Address);
		form.AddField ("DobPost", Dob);
		WWW www = new WWW (LoginURL, form);

		yield return www;

		Debug.Log(www.text);
	//	if (www.text == "Everytinh is ok.") {
	//		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	//	}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour {

	public Text NAME;
	public Text  inputusername  ;
	public Text inputpassword  ;
	public Text inputmonth;
	public Text inputday;
	public Text inputyear;
	public string NAME1;
	public string inputusername1;
	public string inputpassword1;
	public string Dob;
	public string Stat;
	string LoginURL = "localhost/thesis/Login.php";
	public GameObject logpanel;
	public GameObject logtxt;
	public GameObject incpwdtxt;
	public GameObject errorbtn;
	public GameObject errortxt;
	public GameObject nusermessage;
	public GameObject nuserbtn;
	public GameObject nusertxt;
    public GameObject useractive;
    public GameObject useractivebtn;
    public GameObject useractivetxt;


	// Use this for initialization
	//void Start () {
		
	//}
	public void LOGIN ()	
	{
	
		Stat = "Offline";
		inputusername1 = inputusername.text;
		inputpassword1 = inputpassword.text;
		Dob = inputmonth.text + " " + inputday.text + "," + inputyear.text;
		//if (Input.GetKeyDown (KeyCode.KeypadEnter))
			StartCoroutine(LoginToDB (inputusername1, inputpassword1, Dob, Stat));
	}
	// Update is called once per frame
	//void Update () {
		
	
		
	//}

	IEnumerator LoginToDB(string Username, string Password, string Dob, string Stat){
	WWWForm form = new WWWForm ();
	form.AddField("UsernamePost", Username);
	form.AddField("PasswordPost", Password);
	form.AddField("DobPost", Dob);
	form.AddField("StatusPost", Stat);
	WWW www = new WWW (LoginURL, form);
	
	yield return www;
	WWW username = new WWW ("localhost/thesis/session.php");
		yield return username;
	Debug.Log(www.text);
		if (www.text == "login success") 
		{
			logpanel.SetActive(true);
			logtxt.SetActive(true);
		
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		
		}
		else if (www.text == "Welcome Admin")
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);

		}
		else if (www.text == "password incorrect")
		{
			logpanel.SetActive(true);
			incpwdtxt.SetActive(true);
			errorbtn.SetActive(true);
			errortxt.SetActive(true);
		}
		else if (www.text == "user not found")
		{
			logpanel.SetActive(true);
			nuserbtn.SetActive(true);
			nusermessage.SetActive(true);
			nusertxt.SetActive(true);
		}
		else if(www.text == "User already Active")
		{
            logpanel.SetActive(true);
            useractive.SetActive(true);
            useractivebtn.SetActive(true);
            useractivetxt.SetActive(true);

		}
	}
}

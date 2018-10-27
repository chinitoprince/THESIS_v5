using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class popupmessage : MonoBehaviour {
		const float duration =3.0f;

	public GameObject RegisteredText;
	public GameObject RegisteredPanel;
	public GameObject RegisteredBTN;
	public GameObject okbtn;
	public GameObject oktxt;
	public InputField fullname;
	public InputField password;
	public InputField section;
	public InputField adviser;
	public InputField address;

	public GameObject logpanel;
	public GameObject logtxt;
	public GameObject errorbtn;
	public GameObject errortxt;
	public GameObject nusermessage;
	public GameObject nuserbtn;
	public GameObject nusertxt;
    public GameObject useractive;
    public GameObject useractivebtn;
    public GameObject useractivetxt;

	public void ok()
	{
		RegisteredText.SetActive(false);
		RegisteredPanel.SetActive(false);
		RegisteredBTN.SetActive(true);
		okbtn.SetActive(false);
		oktxt.SetActive(false);
		
		fullname.text="";
		password.text="";
		section.text="";
		adviser.text="";
		address.text="";	
				}

	public void login()
	{

			logpanel.SetActive(false);
			logtxt.SetActive(false);
			errorbtn.SetActive(false);
			errortxt.SetActive(false);
			nuserbtn.SetActive(false);
			nusermessage.SetActive(false);
			nusertxt.SetActive(false);
            useractive.SetActive(false);
            useractivebtn.SetActive(false);
            useractivetxt.SetActive(false);
	}

}

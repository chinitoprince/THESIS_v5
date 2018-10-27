using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataLoader : MonoBehaviour {

	public string[] ques;
	  public bool isTrue;
	[SerializeField]
    private Text factsText;

	void Start(){
		StartCoroutine(callme());
	}
	IEnumerator callme () {
		WWW questions = new WWW ("http://localhost/thesis/ques.php");
		yield return questions;
		string questionstring = questions.text;
		ques = questionstring.Split(';');
		 int randomQuestionIndex = Random.Range(0,170);
		 Debug.Log(randomQuestionIndex);
		 factsText.text=GetDataValue(ques[randomQuestionIndex], "Question:");
		print(GetDataValue(ques[randomQuestionIndex], "Question:"));
		GetDataValue(ques[randomQuestionIndex], "Question:").Remove(randomQuestionIndex);	
	}

	string GetDataValue(string data, string index)
	{
		
		string value = data.Substring(data.IndexOf(index)+index.Length);
		if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
		return value;

	}
	
	
}

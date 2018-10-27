using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    [SerializeField]
    private Text C1;
    [SerializeField]
    private Text C2;
    [SerializeField]
    private Text C3;
    [SerializeField]
    private Text C4;
    [SerializeField]
    private Text C5;
    [SerializeField]
    private Text C6;
    public string[] ques;
	  public bool isTrue;
	[SerializeField]
    private Text factsText;
    public Question[] questions;
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;
    [SerializeField]
    private Text factText;
    [SerializeField]
    private float timeBetweenQuestions = 1f;
    [SerializeField]
    private Text trueAnswerText;
    [SerializeField]
    private Text falseAnswerText;


    public GameObject A1;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject q1;
    void Start()
    {
        if(unansweredQuestions == null || unansweredQuestions.Count == 0 )
        {
            unansweredQuestions= questions.ToList<Question>();
        
        }
        StartCoroutine(callme());
        SetCurrentQuestion();
        Debug.Log(currentQuestion.fact);
        }
    void SetCurrentQuestion ()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];
        factText.text = currentQuestion.fact;
   Debug.Log(randomQuestionIndex);
 
		unansweredQuestions.RemoveAt (randomQuestionIndex);
    }

    IEnumerator TransitionToNextQuestion ()
    {

        yield return new WaitForSeconds (timeBetweenQuestions);
                    b2.SetActive(true);
                    b3.SetActive(true);
                    b4.SetActive(true);
     //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectTrue()
    {
        if (currentQuestion.isTrue)
        {
            Debug.Log("Correct!");
        }else
        {
                Debug.Log("Wrong");
        }
          A1.SetActive(true);
        b1.SetActive(false);
        q1.SetActive(false);
        b2.SetActive(false);
        b3.SetActive(false);
        b4.SetActive(false);
        StartCoroutine(TransitionToNextQuestion());
//        SetCurrentQuestion();
        StartCoroutine(callme());
    }  
    public void UserSelectFalse()
    {
        if (!currentQuestion.isTrue)
        {
            Debug.Log("Correct!");
        }else
        {
               Debug.Log("Wrong");
        }
        A1.SetActive(true);
        b1.SetActive(false);
        q1.SetActive(false);
        b2.SetActive(false);
        b3.SetActive(false);
        b4.SetActive(false);
		StartCoroutine(TransitionToNextQuestion());
		StartCoroutine(callme());
  //      SetCurrentQuestion();
    }

    	IEnumerator callme () {
		WWW questions = new WWW ("http://localhost/thesis/exam.php");
		yield return questions;
		string questionstring = questions.text;
		ques = questionstring.Split(';');
		 int randomQuestionIndex = Random.Range(0,4);
		 Debug.Log(randomQuestionIndex);
		 factsText.text=GetDataValue(ques[randomQuestionIndex], "Question:");
         C1.text=GetDataValue(ques[randomQuestionIndex], "Choice_A:");
         C2.text=GetDataValue(ques[randomQuestionIndex], "Choice_B:");
         C3.text=GetDataValue(ques[randomQuestionIndex], "Choice_C:");
         C4.text=GetDataValue(ques[randomQuestionIndex], "Choice_D:");
         C5.text=GetDataValue(ques[randomQuestionIndex], "Choice_E:");
         C6.text=GetDataValue(ques[randomQuestionIndex], "Choice_F:");
		print(GetDataValue(ques[randomQuestionIndex], "Question:"));
		GetDataValue(ques[randomQuestionIndex], "Question:").Remove(randomQuestionIndex);
        GetDataValue(ques[randomQuestionIndex], "Choice_A:").Remove(randomQuestionIndex);
        GetDataValue(ques[randomQuestionIndex], "Choice_B:").Remove(randomQuestionIndex);
        GetDataValue(ques[randomQuestionIndex], "Choice_C:").Remove(randomQuestionIndex);
        GetDataValue(ques[randomQuestionIndex], "Choice_D:").Remove(randomQuestionIndex);
        GetDataValue(ques[randomQuestionIndex], "Choice_E:").Remove(randomQuestionIndex);
        GetDataValue(ques[randomQuestionIndex], "Choice_F:").Remove(randomQuestionIndex);	
	}

	string GetDataValue(string data, string index)
	{
		
		string value = data.Substring(data.IndexOf(index)+index.Length);
		if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
		return value;

	}


}

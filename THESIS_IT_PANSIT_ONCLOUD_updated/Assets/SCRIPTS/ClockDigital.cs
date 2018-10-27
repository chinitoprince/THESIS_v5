using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class ClockDigital : MonoBehaviour {

	// Use this for initialization
    private Text textClock;
	void Start () {
        textClock = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
      //  DateTime time = DateTime.Now;
      


        DateTime theTime = DateTime.Now;
        string date = theTime.ToString("dddd, dd MMMM yyyy");
        string time = theTime.ToString("h:mm tt");
        string datetime = theTime.ToString("yyyy-MM-dd\\THH:mm:ss\\Z");


       /* string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        string second = LeadingZero(time.Second); */
        textClock.text = date + "     " + time;
    }

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');    
    
    }
}

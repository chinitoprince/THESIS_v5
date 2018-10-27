using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {
public GameObject q1;
public GameObject A1;
	// Use this for initialization
	void OnCollisionEnter()
	{
		Debug.Log ("May natamaan");
        q1.SetActive(true);
		A1.SetActive(false);


	}
}

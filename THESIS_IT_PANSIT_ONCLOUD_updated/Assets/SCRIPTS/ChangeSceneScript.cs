using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class ChangeSceneScript : MonoBehaviour {
  
	// Use this for initialization
	public void changescene( string scenename)
	{
		Application.LoadLevel (scenename);

	
	}


}

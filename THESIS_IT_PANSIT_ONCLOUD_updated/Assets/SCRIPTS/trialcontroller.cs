using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trialcontroller : MonoBehaviour {
    public float Rspeed = 50.0f;
    public float Mspeed = 1.0f;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
           float translation = Input.GetAxis("Vertical") * Mspeed;
           translation  *= Time.deltaTime;
           transform.Translate(0, 0, translation); 

            float rotation = Input.GetAxis("Horizontal") * Rspeed;
            rotation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
           
            }
        
        
	}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {
    public Rigidbody rigid_body;
    public float AppliedForceF =1000f;
    public float sideForce = 50f;
    public float UpForce = 30f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

   
  
	// Update is called once per frame
    void FixedUpdate()
    {
        rigid_body.AddForce(0, 0, AppliedForceF * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rigid_body.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        }
        if (Input.GetKey("a"))
        {
            rigid_body.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }


         //Controlling an animation with procedural coded motion		
         //If the Q key is being held down AND no action is currently being performed (we'll go into more about the actions later).
       
}

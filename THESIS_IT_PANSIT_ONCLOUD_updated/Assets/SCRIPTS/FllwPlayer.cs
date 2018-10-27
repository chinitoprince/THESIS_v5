using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FllwPlayer : MonoBehaviour {
    public Transform player;
    public Vector3 offload;
	/*// Use this for initialization
	void Start () {
		
	} */
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offload;
	}
}

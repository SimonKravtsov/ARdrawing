using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCameraBackround : MonoBehaviour {

	public Renderer rend;
	
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}
     
    void Update(){	
			rend.enabled = false;
	}
	 
	 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		   transform.localPosition = new Vector3(-1f, 0f, 0f); //-0.05
	}
}

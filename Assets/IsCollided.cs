using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCollided : MonoBehaviour {
	public bool collided = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision col)
    {
       // if(col.gameObject.name == "CastModelImported")
       // {
            collided = true;
       // }
    }
}

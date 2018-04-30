using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col : MonoBehaviour {

	//void OnCollisionEnter (Collision col)
   // {
     // /  if(col.gameObject.name == "Cube")
     ///   {
	///		Debug.Log("COOOOOOOOOOOOOOOOOOOOOLISION");
            //Destroy(col.gameObject); 
	///		Destroy(gameObject); 
    ///    }
   /// }
	void Update(){
		if(Eraser.erase){
			float distance = Vector3.Distance (transform.position, GameObject.Find("/LMHeadMountedRig/Attachment Hands/Attachment Hand (Left)/Palm/Cube").transform.position);	
			if(distance <= 35f){
				Destroy(gameObject); 
			}
		}
		
	}
	
	
}

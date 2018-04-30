using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveIT : MonoBehaviour {

	void Update(){
		
	}
	public void SnapITT() {
		Debug.Log("Snapshoted");
		ScreenCapture.CaptureScreenshot("Snapshot.png");
		GameObject.Find("/LMHeadMountedRig/Attachment Hands/Attachment Hand (Left)/Palm/Palm UI Pivot Anchor/Palm UI/Buttons Panel (2)/Last Action").GetComponent<TextMesh>().text = "Snapshot saved in root";
	}
	
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : MonoBehaviour {

	public void Draw () {
		Debug.Log("Draw sellected");
		Eraser.erase = false;
		setLine.size=0.3f;
		GameObject.Find("/LMHeadMountedRig/Attachment Hands/Attachment Hand (Left)/Palm/Palm UI Pivot Anchor/Palm UI/Buttons Panel (2)/Last Action").GetComponent<TextMesh>().text = "Last action: pen sellected";
	}
	void Update(){
	GameObject.Find("/LMHeadMountedRig/Attachment Hands/Attachment Hand (Left)/Palm/Palm UI Pivot Anchor/Palm UI/Cube UI Slider Panel/Cube UI Slider/Button Cube/Cube/size").GetComponent<TextMesh>().text = "" + (int)(setLine.size * 10);
	}
}

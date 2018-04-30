using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : MonoBehaviour {
	
	public void colorBlack () {
		Debug.Log("Black sellected");
		setLine.color=Color.black;
		GameObject.Find("/LMHeadMountedRig/Attachment Hands/Attachment Hand (Left)/Palm/Palm UI Pivot Anchor/Palm UI/Buttons Panel (2)/Last Action").GetComponent<TextMesh>().text = "Last action: black sellected";
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour {

	public void colorBlue () {
		Debug.Log("Blue sellected");
		setLine.color=Color.blue;
		GameObject.Find("/LMHeadMountedRig/Attachment Hands/Attachment Hand (Left)/Palm/Palm UI Pivot Anchor/Palm UI/Buttons Panel (2)/Last Action").GetComponent<TextMesh>().text = "Last action: blue sellected";
	}
}

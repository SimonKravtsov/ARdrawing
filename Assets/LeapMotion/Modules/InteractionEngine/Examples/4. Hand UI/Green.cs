using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour {

	public void drawGreen () {
		Debug.Log("Green sellected");
		setLine.color=Color.green;
		GameObject.Find("/LMHeadMountedRig/Attachment Hands/Attachment Hand (Left)/Palm/Palm UI Pivot Anchor/Palm UI/Buttons Panel (2)/Last Action").GetComponent<TextMesh>().text = "Last action:green sellected";
	}
}

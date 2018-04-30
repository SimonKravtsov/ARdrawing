using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour {

	public void colorRed () {
		Debug.Log("Red sellected");
		setLine.color=Color.red;
		GameObject.Find("/LMHeadMountedRig/Attachment Hands/Attachment Hand (Left)/Palm/Palm UI Pivot Anchor/Palm UI/Buttons Panel (2)/Last Action").GetComponent<TextMesh>().text = "Last action: red sellected";
	}
}

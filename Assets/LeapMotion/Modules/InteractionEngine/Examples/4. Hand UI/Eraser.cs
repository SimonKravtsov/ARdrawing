using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eraser : MonoBehaviour {

	public static bool erase = false;
	public void Erase () {
		Debug.Log("Erraser sellected");
		erase = true;
		setLine.size=0f;
		GameObject.Find("/LMHeadMountedRig/Attachment Hands/Attachment Hand (Left)/Palm/Palm UI Pivot Anchor/Palm UI/Buttons Panel (2)/Last Action").GetComponent<TextMesh>().text = "Last action: eraser sellected";
	}
}

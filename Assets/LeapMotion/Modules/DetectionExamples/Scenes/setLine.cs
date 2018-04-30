using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.DetectionExamples;
using UnityEngine.UI;


public class setLine : MonoBehaviour {
	

	public static float size;
	public static Color color= Color.blue;

	
	public void setLineSize (float newSize) {
		Debug.Log("Line size is" + newSize);
		size = newSize;
	}
	
}

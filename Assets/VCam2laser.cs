using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCam2laser : MonoBehaviour {
   void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "ImageTarget")
        {
            Debug.Log("YEYY");
        }
    }
}

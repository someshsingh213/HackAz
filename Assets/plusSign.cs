using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusSign : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject text = new GameObject();
		TextMesh t = text.AddComponent<TextMesh>();
		t.text = "+";
		t.fontSize = 26;
		float x = (float)27.18;
		float y = (float)-2.09;
		float z = (float)-22.85;
		t.transform.localEulerAngles += new Vector3 (0, -90, 0);
		t.transform.localPosition += new Vector3 (x, y, z);
		t.color = new Color(0,0,0,1);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

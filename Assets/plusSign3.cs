using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusSign3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject text = new GameObject();
		TextMesh t = text.AddComponent<TextMesh>();
		t.text = "+";
		t.fontSize = 26;
		float x = (float)26.01;
		float y = (float)-2.3;
		float z = (float)7.00;
		t.transform.localEulerAngles += new Vector3 (0, -90, 0);
		t.transform.localPosition += new Vector3 (x, y, z);
		t.color = new Color(0,0,0,1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

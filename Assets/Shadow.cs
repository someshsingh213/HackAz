﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour {
	public static int number = 7;

	// Use this for initialization
	void Start () {		

		GameObject text = new GameObject();
		TextMesh t = text.AddComponent<TextMesh>();
		//Shadow.number = Random.Range (1, 10);
		//setNumber();
		t.text = number.ToString();
		t.fontSize = 30;
		float x = (float)29.01;
		float y = (float)-1.29;
		float z = (float)-25.69;
		t.transform.localEulerAngles += new Vector3 (0, -90, 0);
		t.transform.localPosition += new Vector3 (x, y, z);
		t.color = new Color(0,0,0,1);


	}
	
	// Update is called once per frame
	void Update () {




	}
}

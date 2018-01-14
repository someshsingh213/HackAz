using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour {

	public float fallSpeed = 0.0f;
	public float spinSpeed = 0.0f;
	// Use this for initialization
	void Start () {


	}



	// Update is called once per frame
	void Update() {

		transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
		//transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);

	}

	//void OnMouseDown() {

		//renderer.enabled = false;

	}





﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CorrectAnswer : MonoBehaviour {

	public GameObject Question1;
	//public GameObject Question2;
	public GameObject Correct1;
//	public GameObject Correct2;


	void Start(){
	
//		MeshRenderer mr = Question2.GetComponent<MeshRenderer>();
//		mr.enabled = false;
	}


	public void Update()

	{  

		if (Input.GetMouseButtonDown(0)){
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
			RaycastHit2D hit = Physics2D.Raycast (mousePos2D, Vector2.zero);

			Debug.Log ("press");

				if(Question1 != null){
					GetComponent<TextMesh>().text = "Is it ok to seek revenge?";
					if (hit.collider.gameObject.tag == "Correct") {
						Debug.Log ("correct hit");
						GetComponent<TextMesh>().text = "";
					}	
				else{
					Debug.Log ("Q2");

					if (hit.collider.gameObject.tag == "Correct") {
						Debug.Log ("correct hit");
						//Destroy (Question2.gameObject);
					}
			
			
				}
			}
		}
	}
}
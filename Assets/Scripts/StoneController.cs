﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour {
	public float fallSpeed=5.0f;
	public float spinSpeed = 250.0f;

	public GameObject plane;
	public float height;


	// Update is called once per frame
	void FixedUpdate () {
		height = Vector3.Distance (plane.transform.position, transform.position);

			//public void translate(Vector3 translation, Space relativeTo=Space.World)
			transform.Translate (Vector3.down * fallSpeed * Time.deltaTime, Space.World);//moves the transform in the direction 
			//and distance of translation
			//if relativeTo is Space.World the movement is applied relative to the world coordinate system
			transform.Rotate (Vector3.forward, spinSpeed * Time.deltaTime);
		if (height <= 0f) {
			
		GetComponent<Renderer>().enabled = false;
		} 

		}
	}
	
	//		void OnTriggerEnter ()
	//	{
	//			StartCoroutine(WaitToDestroy(2));
	//			Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
	//			gameObject.GetComponent<Renderer>().enabled = false;
	//		}
	//	IEnumeratir WaitToDestroy(float time)
	//	{
	//		yield return new WaitForSeconds (time);
	//		Destroy(gameObject);
	//	WaitToDestroy (GameObject.Find ());
	//	}
		
	


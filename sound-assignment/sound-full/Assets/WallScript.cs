using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<MeshRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			gameObject.GetComponent<MeshRenderer> ().enabled = true;
		} 
	}

	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			gameObject.GetComponent<MeshRenderer> ().enabled = false;
		} 
	}
}

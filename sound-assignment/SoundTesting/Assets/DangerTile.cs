using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerTile : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			Debug.Log ("Player is in danger");
		} 
	}

	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			Debug.Log ("Player is in no longer in danger");
		} 
	}
}

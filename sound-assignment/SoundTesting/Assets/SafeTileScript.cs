using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeTileScript : MonoBehaviour {
	public bool isSafe = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("GameManager").GetComponent<AudioControlScript> ().musicOn) {
			gameObject.GetComponent<MeshRenderer> ().enabled = false;
		} else if(!GameObject.Find ("GameManager").GetComponent<AudioControlScript> ().musicOn) {
			gameObject.GetComponent<MeshRenderer> ().enabled = true;
		}
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			Debug.Log ("Tank is safe");
			isSafe = true;
		} 
	}

	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			//gameObject.GetComponent<MeshRenderer> ().enabled = false;
			Debug.Log("Player has left safe tile");
			isSafe = false;
		} 
	}
}

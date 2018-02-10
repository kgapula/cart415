using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "Player") {
			GetComponent<MeshRenderer> ().enabled = true;
			Debug.Log ("touching");
		} else {
			GetComponent<MeshRenderer> ().enabled = false;
			Debug.Log ("not touching");
		}

	}


}

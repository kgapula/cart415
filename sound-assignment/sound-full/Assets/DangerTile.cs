using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerTile : MonoBehaviour {
//	public bool musicOn = true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("GameManager").GetComponent<AudioControlScript> ().musicOn) {
			gameObject.GetComponent<MeshRenderer>().enabled = false;
			gameObject.GetComponent<BoxCollider>().enabled = false;
		} else if(!GameObject.Find ("GameManager").GetComponent<AudioControlScript> ().musicOn) {
			gameObject.GetComponent<MeshRenderer>().enabled = true;
			gameObject.GetComponent<BoxCollider>().enabled = true;
		}
	}

//	public bool setupMusic(bool musicOn) {
////	musicOn = true;
//
//		if (Input.GetKeyDown("m")) {
//			musicOn = !musicOn;
//
//			if (musicOn) {
//				Debug.Log (musicOn);
//				Debug.Log ("Music is on");
//				return true;
//			} else {
//				Debug.Log ("Music is off");
//				return false;
//			}
//
//		}
//		return true;
//	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player" && !GameObject.Find("GameManager").GetComponent<AudioControlScript>().musicOn) {
			//Debug.Log ("Player is in danger");

			collision.gameObject.GetComponent<TankHealth> ().TakeDamage (25f);

//			if (!musicOn) {
//				Debug.Log ("Player has taken damage");
//			}

		}
	}

	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.tag == "Player" && !GameObject.Find("GameManager").GetComponent<AudioControlScript>().musicOn) {
			//Debug.Log ("Player is in no longer in danger");
		} 
	}
}

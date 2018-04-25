using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour {
	//public Material[] mats;
	public Material theOldMaterial;
	public Material theNewMaterial;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("GameManager").GetComponent<AudioControlScript> ().musicOn) {
			GetComponent<Renderer> ().material = theNewMaterial;
		} else {
			GetComponent<Renderer> ().material = theOldMaterial;
		}
	}
}

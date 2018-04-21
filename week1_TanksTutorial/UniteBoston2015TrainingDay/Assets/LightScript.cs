using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {

	public Light DirectionalLight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter (Collider other) {

		//if the block was hit by a shell
		if (other.gameObject.tag == "Shell") {
			Debug.Log ("Light object was hit");

			DirectionalLight.color = Random.ColorHSV (0f, 1f, 1f, 1f, 0.5f, 1f);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightResetScript : MonoBehaviour {

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
			Debug.Log ("Light reset object was hit");

			DirectionalLight.color = Color.white;
		}
	}
}

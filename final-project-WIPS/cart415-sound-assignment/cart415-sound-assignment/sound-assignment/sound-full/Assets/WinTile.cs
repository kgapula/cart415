using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTile : MonoBehaviour {
	public bool finished = false;

	// Use this for initialization
	void Start () {
		finished = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Player") {
			finished = true;
			Debug.Log ("FINISHED");
			GameObject.Find ("WinTile").SendMessage ("Finish");
		}
	}
}

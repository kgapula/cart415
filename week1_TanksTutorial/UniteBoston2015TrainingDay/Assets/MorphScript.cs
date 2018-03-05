using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorphScript : MonoBehaviour {
	public Transform Tree;
	//future: create an array to store model names and pull those names randomly when instantiating new objects
	[SerializeField] public string[] objectArray;
//	public string[] objectArray = new string[]{"Object1", "Object2"};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public string GetRandomString() {
		return objectArray [Random.Range (0, objectArray.Length)];
	}

	void OnCollisionEnter (Collision collision) {
		//if the block was hit by a shell
		if (collision.gameObject.tag == "Shell") {
			Debug.Log ("Morph object was hit");
			//GetRandomString ();
			//change the model by placing a new object
			Instantiate (Tree, transform.position, transform.rotation);
			//destroy the old object
			Destroy (gameObject);
		}
	}
}

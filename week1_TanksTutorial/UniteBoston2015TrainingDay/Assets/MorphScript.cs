using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorphScript : MonoBehaviour {
		

		List<Transform> prefabList = new List<Transform>();
		public Transform Cactus;
		public Transform BustedTank;
		public Transform Helipad;
		public Transform Tree;
		public Transform OilStorage;
		public Transform Building;
		public Transform Building2;

	//public GameObject OilStorage;

	//future: create an array to store model names and pull those names randomly when instantiating new objects
	//[SerializeField] public string[] objectArray;
//	public string[] objectArray = new string[]{"Object1", "Object2"};



	// Use this for initialization
	void Start () {
		prefabList.Add (Cactus);
		prefabList.Add (BustedTank);
		prefabList.Add (Helipad);
		prefabList.Add (Tree);
		prefabList.Add (OilStorage);
		prefabList.Add (Building);
		prefabList.Add (Building2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

//	void OnCollisionEnter (Collision collision) {
//		
//		//if the block was hit by a shell
//		if (collision.gameObject.tag == "Player") {
//			Debug.Log ("Morph object was hit");
//
//			//get a random object from the array
//			int prefabIndex = UnityEngine.Random.Range(0,prefabList.Count-1);
//			Debug.Log (prefabIndex);
//
//			//change the model by placing a new object
//			//Instantiate (Tree, transform.position, transform.rotation);
//			Instantiate(prefabList[prefabIndex], transform.position, transform.rotation);
//
//			//destroy the old object
//			Destroy (gameObject);
//		}
//	}

	void OnTriggerEnter (Collider other) {

		//if the block was hit by a shell
		if (other.gameObject.tag == "Shell") {
			Debug.Log ("Morph object was hit");

			//get a random object from the array
			int prefabIndex = UnityEngine.Random.Range(0,prefabList.Count-1);
			Debug.Log (prefabIndex);

			//change the model by placing a new object
			//Instantiate (Tree, transform.position, transform.rotation);
			Instantiate(prefabList[prefabIndex], transform.position, transform.rotation);

			//destroy the old object
			Destroy (gameObject);
		}
	}

}

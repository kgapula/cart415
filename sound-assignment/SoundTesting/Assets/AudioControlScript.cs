using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControlScript : MonoBehaviour {

	//create variable for the audio source
	[SerializeField] AudioSource backgroundMusic;
	//create the boolean toggling the audiosource on and off
	public bool musicOn = true;

	// Use this for initialization
	void Start () {
		backgroundMusic = GetComponent<AudioSource> ();
	}


	
	// Update is called once per frame
	void Update () {
//		Debug.Log (GetComponent<DangerTile> ().setupMusic (musicOn));
//		if (GetComponent<DangerTile> ().setupMusic (musicOn: true)) {
//		if(musicOn) {
//			backgroundMusic.mute = !backgroundMusic.mute;
		//		}
		if (Input.GetKeyDown ("m")) {
			musicOn = !musicOn;
			Debug.Log ("musicOn = " + musicOn);
		}
}

	public bool setupMusic(bool musicOn) {
			if (musicOn) {
				Debug.Log (musicOn);
				Debug.Log ("Music is on");
				backgroundMusic.mute = false;
				return true;
			} else {
				Debug.Log ("Music is off");
				backgroundMusic.mute = true;
				return false;
			}
		//		return true;
	}
}

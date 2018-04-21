using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControlScript : MonoBehaviour {

	//create variable for the audio source
	[SerializeField] AudioSource backgroundMusic;
	[SerializeField] AudioSource whistle;
	//create the boolean toggling the audiosource on and off
	public bool musicOn = true;
	private float nextActionTime = 0.0f;
	private float soundTime = 0.0f;
	private bool timeForSound = false;
	public float period = 5f;

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



//		if (Input.GetKeyDown ("m")) {
//			musicOn = !musicOn;
//			Debug.Log ("musicOn = " + musicOn);
//		}
		period = Random.Range(2, 5);

		if (Time.time >= nextActionTime) {
			whistle.Play ();
		}

		if (Time.time >= nextActionTime) {
			nextActionTime += period;
			//nextActionTime-1
			//whistle.Play ();
			musicOn = !musicOn;

		}

		if (!musicOn) {
			backgroundMusic.mute = true;
		} else {
			backgroundMusic.mute = false;
		}
}
		
//	public bool setMusic(bool musicOn) {
//		//if the boolean musicOn is true, play the background music
//			if (musicOn) {
//				Debug.Log (musicOn);
//				Debug.Log ("Music is on");
//				//backgroundMusic.mute = false;
//				gameObject.GetComponent<AudioSource> ().enabled = true;
//				return true;
//			} else {
//			//if the boolean is false, pause the background music
//				Debug.Log ("Music is off");
//				//backgroundMusic.mute = true;
//				//backgroundMusic.Pause();
//				gameObject.GetComponent<AudioSource> ().enabled = false;
//				return false;
//			}
//		//		return true;
//	}
}

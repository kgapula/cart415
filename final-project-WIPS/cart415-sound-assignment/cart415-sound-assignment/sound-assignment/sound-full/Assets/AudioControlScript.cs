using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
	public Text countText;
	public float nextActionTimeText = 0.0f;


	// Use this for initialization
	void Start () {
		backgroundMusic = GetComponent<AudioSource> ();

	}


	
	// Update is called once per frame
	void Update () {

		period = Random.Range(2, 5);

		if (Time.time >= nextActionTime) {
			whistle.Play ();
		}

		if (Time.time >= nextActionTime) {
			nextActionTime += period;
			nextActionTimeText = (nextActionTime - Time.time);
			Debug.Log ("nextActionTime" + " " + (nextActionTime - Time.time));


			musicOn = !musicOn;

		}

		if (!musicOn) {
			backgroundMusic.mute = true;
		} else {
			backgroundMusic.mute = false;
		}

		setText ();
}

	void setText() {
		int roundedNextAction = Mathf.CeilToInt (nextActionTimeText);
		countText.text = "Next Action in: " + roundedNextAction.ToString();
	}

}

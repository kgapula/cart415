using UnityEngine;

public class rotate : MonoBehaviour {

	public float speed = 100.0f;
	public Light directionalLight;
	Vector3 angle;
	float rotation = 0f;
	Color initialColor = new Color32(0xFF, 0xEE, 0xB6, 0xFF);

	public enum Axis
	{
		X,
		Y,
		Z
	}
	public Axis axis = Axis.X;
	public bool direction = true;

	void Start()
	{
		angle = transform.localEulerAngles;
	}

	void Update()
	{
		if (GameObject.Find ("GameManager").GetComponent<AudioControlScript> ().musicOn) {
			directionalLight.color = Color.blue;
			switch (axis) {
			case Axis.X:
				transform.localEulerAngles = new Vector3 (Rotation (), angle.y, angle.z);
				break;
			case Axis.Y:
				transform.localEulerAngles = new Vector3 (angle.x, Rotation (), angle.z);
				break;
			case Axis.Z:
				transform.localEulerAngles = new Vector3 (angle.x, angle.y, Rotation ());
				break;
			}
		}

		if (!GameObject.Find ("GameManager").GetComponent<AudioControlScript> ().musicOn) {
			directionalLight.color = initialColor;
		}
	}

	float Rotation()
	{
		rotation += speed * Time.deltaTime;
		if (rotation >= 360f) 
			rotation -= 360f; // this will keep it to a value of 0 to 359.99...
		return direction ? rotation : -rotation;
	}
}
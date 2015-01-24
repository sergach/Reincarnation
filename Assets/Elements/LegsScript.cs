using UnityEngine;
using System.Collections;

public class LegsScript : MonoBehaviour {

	public GameObject leftLeg;
	public GameObject rightLeg;

	private bool go = false;
	private float time;

	private Vector2 startLeft;
	private Vector2 startRight;

	void Start(){
		startLeft = new Vector2 (leftLeg.transform.localPosition.x, leftLeg.transform.localPosition.y);
		startRight = new Vector2 (rightLeg.transform.localPosition.x, rightLeg.transform.localPosition.y);
	}

	public void Go() {
		go = true;
		time = 0;
	}

	public void Stop() {
		go = false;
		time = 0;
		leftLeg.transform.localPosition = new Vector3 (startLeft.x, startLeft.y + 0.05f * Mathf.Sin (0), 0);
		rightLeg.transform.localPosition = new Vector3 (startRight.x, startRight.y + 0.05f * Mathf.Sin (0), 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (go) {
			time -= Time.deltaTime * 12;
			leftLeg.transform.localPosition = new Vector3 (-0.17f, 0.05f * Mathf.Sin (time), 0);
			rightLeg.transform.localPosition = new Vector3 (0.17f, 0.05f * Mathf.Sin (time + 3.14f), 0);
		}
	}
}
